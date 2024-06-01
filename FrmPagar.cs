using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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

        /*private void btnPagar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDNI.Text, out int dniCliente))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }
            

            // Obtener los datos del formulario
            // int nSocio = int.Parse(txtDNI.Text);
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
            int nSocio = gestionPago.ObtenerNSocioPorDNI(dniCliente);
            if (nSocio == 0)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            // Calcular el monto total que debe pagar el cliente
            float montoTotal = gestionPago.CalcularMontoTotal(nSocio);
            string resultado = gestionPago.RealizarPago(pago);

            // Mostrar resultado
            MessageBox.Show(resultado);
        }*/
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDNI.Text, out int dniCliente))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            // Crear instancia de la clase Pagar
            Pagar gestionPago = new Pagar();

            // Obtener el NSocio (ID del cliente) a partir del DNI
            int nSocio = gestionPago.ObtenerNSocioPorDNI(dniCliente);
            if (nSocio == 0)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            // Obtener la forma de pago y las cuotas
            string formaPago = optEfvo.Checked ? "Efectivo" : "Tarjeta";
            int cuotas = rbTarjeta.Checked ? (rbTarjeta.Checked ? 3 : 6) : 1;

            // Calcular el monto total que debe pagar el cliente
            float montoTotal = gestionPago.CalcularMontoTotal(nSocio);

            // Crear instancia de la clase E_Pagar con los datos obtenidos
            E_Pagar pago = new E_Pagar
            {
                NSocio = nSocio,
                FormaPago = formaPago,
                Cuotas = cuotas,
                Monto = montoTotal, // Utilizamos el monto total calculado
                FechaPago = DateTime.Now
            };
            int ultimoID = gestionPago.ObtenerUltimoIDPago();

            // Generar un nuevo ID único
            int nuevoID = ultimoID + 1;

            // Asignar el nuevo ID al pago
            pago.IDPago = nuevoID;


            // Registrar el pago
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
