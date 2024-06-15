using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.TimeZoneInfo;

namespace SistemaClubDeportivo2
{
    public partial class FrmFactura : Form
    {
        public FrmFactura(
            DateTime fechaActual,
            string nombreCliente,
            List<string> actividadesRealizadas,
            DateTime fechaVencimientoCuota,
            string formaPago,
            float monto,
            int cuotas
            
        )
        {
            InitializeComponent();
            txtFechaActual.Text = fechaActual.ToShortDateString();
            txtNombreCliente.Text = nombreCliente;            
            txtFechaVencimiento.Text = fechaVencimientoCuota.ToShortDateString();
            txtFormaPago.Text = formaPago;
            txtMonto.Text = monto.ToString("C");

            if (formaPago == "Tarjeta" && cuotas > 1)
            {
                txtCuotas.Text = $"{cuotas} cuotas de ${monto / cuotas:0.00}";
            }
            else
            {
                txtCuotas.Text = "Pago en una sola cuota";
            }
        }

        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true;

            MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();



        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
    }
}

        