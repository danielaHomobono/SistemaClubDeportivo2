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



            //int idInscri = gestionPago.ObtenerIdInscripcion(nSocio);
           // if (idInscri == 0)
           // {
                //MessageBox.Show("Inscripción no encontrada.");
                //return;
            //}

            string formaPago = optEfvo.Checked ? "Efectivo" : "Tarjeta";
            bool tipoPago = optCuota.Checked;
            int cuotas = formaPago == "Tarjeta" ? (opt3Cuotas.Checked ? 3 : 6) : 1;

            float montoTotal = gestionPago.CalcularMontoTotal(nSocio, esSocio, tipoPago, cuotas);

            List<string> actividadesInscritas = gestionPago.ObtenerActividadesInscritas(nSocio);

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
                TipoPago = tipoPago ? "Cuota" : "Actividad"
            };

            int ultimoID = gestionPago.ObtenerUltimoIDPago();
            int nuevoID = ultimoID + 1;
            pago.IDPago = nuevoID;

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

        /*private void btnPagar_Click(object sender, EventArgs e)
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

            int idInscri = gestionPago.ObtenerIdInscripcion(nSocio);
            if (idInscri == 0)
            {
                MessageBox.Show("Inscripción no encontrada.");
                return;
            }
            bool esPagoCuota = esSocio;

            string formaPago = optEfvo.Checked ? "Efectivo" : "Tarjeta";
            //string tipoPago = optCuota.Checked ? "Cuota" : "Actividad";
            bool tipoPago = optCuota.Checked;
            int cuotas = formaPago == "Tarjeta" ? (opt3Cuotas.Checked ? 3 : 6) : 1;

            float montoTotal = gestionPago.CalcularMontoTotal(nSocio, esSocio, tipoPago, cuotas);

            List<string> actividadesInscritas = gestionPago.ObtenerActividadesInscritas(nSocio);

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
                TipoPago = tipoPago ? "Cuota" : "Actividad"
            };

            int ultimoID = gestionPago.ObtenerUltimoIDPago();
            int nuevoID = ultimoID + 1;
            pago.IDPago = nuevoID;

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
        }*/

        /*private void btnPagar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDNI.Text, out int dniCliente))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            // Crear instancia de la clase Pagar
            Pagar gestionPago = new Pagar();

           
            int nSocio = gestionPago.ObtenerNSocioPorDNI(dniCliente);
            if (nSocio == 0)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            string nombreCliente = gestionPago.ObtenerNombreCliente(dniCliente);
            int idInscri = gestionPago.ObtenerIdInscripcion(nSocio);
            if (idInscri == 0)
            {
                MessageBox.Show("Inscripción no encontrada.");
                return;
            }
            // Obtener la forma de pago y las cuotas
            string formaPago = optEfvo.Checked ? "Efectivo" : "Tarjeta";
            
            // Calcular el monto total que debe pagar el cliente
            float montoTotal = gestionPago.CalcularMontoTotal(nSocio);

            List<string> actividadesInscritas = gestionPago.ObtenerActividadesInscritas(nSocio);


            E_Pagar pago = new E_Pagar
            {
                NCliente = nSocio,
                FormaPago = formaPago,
                
                Monto = montoTotal, 
                FechaPago = DateTime.Now,
                NombreCliente = nombreCliente,
                ActividadesInscritas = actividadesInscritas,
                //ActividadesInscritas = pagoActual?.ActividadesInscritas ?? new List<string>(),
                IdInscri = idInscri
                
            };

            int ultimoID = gestionPago.ObtenerUltimoIDPago();

            // Generar un nuevo ID único
            int nuevoID = ultimoID + 1;

            // Asignar el nuevo ID al pago
            pago.IDPago = nuevoID;

            // Registrar el pago
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
        }*/

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
    }
}












