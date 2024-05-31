using SistemaClubDeportivo2.Datos;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    public partial class FrmPagar : Form
    {
       /* public FrmPagar()
        {
            InitializeComponent();
        }*/

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            int nSocio = int.Parse(txtDNI.Text);
            string formaPago = optEfvo.Checked ? "Efectivo" : "Tarjeta";
            int cuotas = rbTarjeta.Checked ? (rbTarjeta.Checked ? 3 : 6) : 1;
            float tarifaMensual = 50.0f;
            float monto = tarifaMensual * cuotas;

            DateTime fechaPago = DateTime.Now;

            // Crear instancia de la clase E_Pagar
            E_Pagar pago = new E_Pagar
            {
                NSocio = nSocio,
                FormaPago = formaPago,
                Cuotas = cuotas,
                Monto = monto,
                FechaPago = fechaPago
            };

            // Registrar el pago
            Pagar gestionPago = new Pagar();
            string resultado = gestionPago.RealizarPago(pago);

            // Mostrar resultado
            MessageBox.Show(resultado);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            // Mostrar comprobante de pago (opcional)
        }
    }
}
