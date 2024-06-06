using MySql.Data.MySqlClient;
using SistemaClubDeportivo2.Datos;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    public partial class FrmPagar : Form
    {

        private E_Pagar pagoActual;

        public FrmPagar(E_Pagar pago)
        {
            InitializeComponent();

            pagoActual = pago;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDNI.Text, out int dniCliente))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            Pagar gestionPago = new Pagar();

            int nSocio = gestionPago.ObtenerNSocioPorDNI(dniCliente);
            if (nSocio == 0)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            string nombreCliente = gestionPago.ObtenerNombreCliente(dniCliente);
            bool esSocio = gestionPago.EsSocio(dniCliente);
            if (esSocio)
            {
                MessageBox.Show("El cliente es socio. Proceder con el pago.");
            }
            else
            {
                MessageBox.Show("El cliente no es socio. Proceder con el pago de actividades.");
            }

            int idInscri = esSocio ? 0 : gestionPago.ObtenerIdInscripcion(nSocio);




            string formaPago = optEfvo.Checked ? "Efectivo" : "Tarjeta";
            bool tipoPago = optCuota.Checked;
            bool esCuotaMensual = optCuotaMensual.Checked;
            int cuotas = formaPago == "Tarjeta" ? (opt3Cuotas.Checked ? 3 : 6) : 1;

            float montoTotal = gestionPago.CalcularMontoTotal(nSocio, esSocio, tipoPago, esCuotaMensual, cuotas);


            lblNombreCliente.Text = "Nombre del Cliente: " + nombreCliente;
            lblMontoTotal.Text = "Monto Total a Pagar: $" + montoTotal.ToString("0.00");



            List<string> actividadesInscritas = gestionPago.ObtenerActividadesInscritas(nSocio);

            //DateTime fechaVencimiento = DateTime.Now.AddMonths(1); // Calcula la fecha de vencimiento
            DateTime fechaVencimiento = DateTime.Now.AddMonths(1); // Calcula la fecha de vencimiento mensual
            if (!esCuotaMensual)
            {
                fechaVencimiento = DateTime.Now.AddDays(1); // Calcula la fecha de vencimiento diaria
            }


            E_Pagar pago = new E_Pagar
            {
                NCliente = nSocio,
                FormaPago = formaPago,
                Cuotas = cuotas,
                Monto = montoTotal,
                FechaPago = DateTime.Now,
                NombreCliente = nombreCliente,
                ActividadesInscritas = actividadesInscritas,
                IdInscri = idInscri,
                EsSocio = esSocio,
                TipoPago = tipoPago ? "Cuota" : "Actividad",
                FechaVencimiento = fechaVencimiento ,
                EsCuotaMensual = esCuotaMensual
            };

            int ultimoID = gestionPago.ObtenerUltimoIDPago();
            int nuevoID = ultimoID + 1;
            pago.IDPago = nuevoID;


            float montoTotalReal = esCuotaMensual ? 2000 : 100; // Ajustar el monto total real
            pago.Monto = montoTotalReal;



            string resultado = gestionPago.RealizarPago(pago);
            if (!string.IsNullOrEmpty(nombreCliente))
            {
                MessageBox.Show($"Pago realizado por {nombreCliente}: {resultado}");
            }
            else
            {
                MessageBox.Show(resultado);
            }
            pago.NombreCliente = nombreCliente;
            pagoActual = pago;

            string actividadesLog = string.Join(", ", pago.ActividadesInscritas);
            Console.WriteLine("Actividades Inscritas en btnPagar_Click: " + actividadesLog);
            MessageBox.Show("Actividades Inscritas en btnPagar_Click: " + actividadesLog);
            
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (pagoActual != null && pagoActual.ActividadesInscritas != null)
            {


                FrmFactura frmFactura = new FrmFactura(
                    DateTime.Now,
                    pagoActual.NombreCliente,
                    pagoActual.ActividadesInscritas,
                    pagoActual.FechaPago.AddMonths(1),
                    pagoActual.FormaPago,
                    pagoActual.Monto,
                    pagoActual.Cuotas,
                    optCuota.Checked
                );

                frmFactura.Show();
            }
            else
            {
                MessageBox.Show("No se pudo obtener los datos del pago.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDNI.Text, out int dniCliente))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            Pagar gestionPago = new Pagar();

            int nSocio = gestionPago.ObtenerNSocioPorDNI(dniCliente);
            if (nSocio == 0)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            string nombreCliente = gestionPago.ObtenerNombreCliente(dniCliente);
            bool esSocio = gestionPago.EsSocio(dniCliente);
            DateTime fechaVencimiento = gestionPago.ObtenerFechaVencimiento(nSocio);
            string tipoPago = gestionPago.ObtenerTipoPago(nSocio);
            float montoTotal = gestionPago.CalcularMontoTotal(nSocio, esSocio, optCuota.Checked, optCuotaMensual.Checked);

            float montoDiario = montoTotal / 30;

            // Mostrar el nombre del cliente y el monto total en las etiquetas correspondientes
            lblNombreCliente.Text = "Nombre del Cliente: " + nombreCliente;
            lblMontoTotal.Text = "Monto Total a Pagar: $" + montoTotal.ToString("0.00");
            lblMontoDiario.Text = "Monto Diario: $" + montoDiario.ToString("0.00");
            lblFechaVencimiento.Text = "Fecha de Vencimiento: " + fechaVencimiento.ToString("dd/MM/yyyy");
            lblTipoPago.Text = "Tipo de Pago: " + tipoPago ;
        }
    }
}












