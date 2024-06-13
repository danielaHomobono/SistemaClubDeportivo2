using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    public partial class FrmImprimirCarnet : Form
    {
        private string nombre;
        private string apellido;
        private string documento;
        private string numeroSocio;
        private EventHandler TransitionTimer_Tick;

        public FrmImprimirCarnet(string nombre, string apellido, string documento, string numeroSocio)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.numeroSocio = numeroSocio;

            transitionTimer.Interval = 6000; // 3 segundos
            transitionTimer.Tick += TransitionTimer_Tick;
            transitionTimer.Enabled = true;
        }

        private void FrmImprimirCarnet_Load(object sender, EventArgs e)
        {
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtDocumento.Text = documento;
            txtNumeroSocio.Text = numeroSocio;
             lblDfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        //private async void btnImprimir_Click(object sender, EventArgs e)
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
            /*btnImprimir.Visible = false;
            await Task.Delay(2000);
            transitionTimer.Start();

            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
            transitionTimer.Stop();*/
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
        // public FrmImprimirCarnet()
        //{

        //}
    }
}
