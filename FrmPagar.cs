
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

            optEfvo.CheckedChanged += new EventHandler(FormaPagoChanged);
            optTarjeta.CheckedChanged += new EventHandler(FormaPagoChanged);
            optCuotaMensual.CheckedChanged += new EventHandler(CuotaChanged);
            optCuotaDiaria.CheckedChanged += new EventHandler(CuotaChanged);
        }
        private void FormaPagoChanged(object sender, EventArgs e)
        {
            if (optEfvo.Checked)
            {
                // Si se selecciona efectivo, deshabilitar opciones de cuotas
                opt3Cuotas.Enabled = false;
                opt6Cuotas.Enabled = false;
                opt3Cuotas.Checked = false; // Desmarcar cualquier opción de cuotas seleccionada
                opt6Cuotas.Checked = false;
            }
            else if (optTarjeta.Checked)
            {
                // Si se selecciona tarjeta, habilitar opciones de cuotas
                opt3Cuotas.Enabled = true;
                opt6Cuotas.Enabled = true;
            }
        }
            private void CuotaChanged(object sender, EventArgs e)
            {
                if (optCuotaDiaria.Checked)
                {
                    // Si se selecciona cuota diaria, deshabilitar la opción de tarjeta
                    optTarjeta.Enabled = false;
                    optEfvo.Checked = true; // Seleccionar efectivo por defecto
                }
                else if (optCuotaMensual.Checked)
                {
                    // Si se selecciona cuota mensual, habilitar todas las opciones de pago
                    optTarjeta.Enabled = true;
                }
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




            if (!esSocio && idInscri == 0)
            {
                MessageBox.Show("Error: No se encontró la inscripción para el cliente no socio.");
                return;
            }







            string formaPago = optEfvo.Checked ? "Efectivo" : "Tarjeta";
            //bool tipoPago = optCuota.Checked;
            string tipoPago = esSocio ? "cuota" : "actividad";
            bool esCuotaMensual = optCuotaMensual.Checked;
            int cuotas = 1;
            if (optTarjeta.Checked)
            {
                cuotas = opt3Cuotas.Checked ? 3 : 6;
            }
            

            float montoTotal = gestionPago.CalcularMontoTotal(nSocio, esSocio, esCuotaMensual, cuotas);





            List<string> actividadesInscritas = gestionPago.ObtenerActividadesInscritas(nSocio);

           
            DateTime fechaVencimiento = DateTime.Now.AddMonths(1); // Calcula la fecha de vencimiento mensual
            if (!esCuotaMensual)
            {
                int diasDelMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                montoTotal = montoTotal / diasDelMes;
            }
            else if (cuotas > 1)
            {
                montoTotal = montoTotal / cuotas;
            }
            //fechaVencimiento = DateTime.Now.AddDays(1);             }
            lblNombreCliente.Text = "Nombre del Cliente: " + nombreCliente;
            lblMontoTotal.Text = "Monto Total a Pagar: $" + montoTotal.ToString("0.00");


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
                TipoPago = esSocio ? "Cuota de Socio" : "Actividad",
                FechaVencimiento = fechaVencimiento,
                EsCuotaMensual = esCuotaMensual
            };

            int ultimoID = gestionPago.ObtenerUltimoIDPago();
            int nuevoID = ultimoID + 1;
            pago.IDPago = nuevoID;





            string resultado = gestionPago.RealizarPago(pago);

            if (resultado.StartsWith("Error"))
            {
                MessageBox.Show($"Error al realizar el pago: {resultado}");
            }
            else
            {
                MessageBox.Show($"Pago realizado por {nombreCliente}: {resultado}");
            }
            pago.NombreCliente = nombreCliente;
            pagoActual = pago;

            string actividadesLog = string.Join(", ", pago.ActividadesInscritas);
            Console.WriteLine("Actividades Inscritas: " + actividadesLog);
            MessageBox.Show("Actividades Inscritas: " + actividadesLog);

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
                    pagoActual.Cuotas
                //optCuota.Checked
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
            bool esCuotaMensual = optCuotaMensual.Checked;
            float montoTotal = gestionPago.CalcularMontoTotal(nSocio, esSocio, optCuotaMensual.Checked);


            float montoDiario = montoTotal / 30;

            // Mostrar el nombre del cliente y el monto total en las etiquetas correspondientes
            lblNombreCliente.Text = "Nombre del Cliente: " + nombreCliente;
            lblMontoTotal.Text = "Monto Total a Pagar: $" + montoTotal.ToString("0.00");
            lblMontoDiario.Text = "Monto Diario: $" + montoDiario.ToString("0.00");
            lblFechaVencimiento.Text = "Fecha de Vencimiento: " + fechaVencimiento.ToString("dd/MM/yyyy");
            lblTipoPago.Text = "Tipo de Pago: " + tipoPago;
        }
    }
}