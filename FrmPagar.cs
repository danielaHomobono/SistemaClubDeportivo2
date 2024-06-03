using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using SistemaClubDeportivo2.Datos;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaClubDeportivo2
{
    public partial class FrmPagar : Form
    {
        // public FrmPagar()
        //{
        // InitializeComponent();
        // }
        /*private E_Pagar pagoActual;
        public FrmPagar(E_Pagar pago)        
        {
            InitializeComponent();
            pagoActual = pago;
        }*/
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

            // Crear instancia de la clase Pagar
            Pagar gestionPago = new Pagar();

            // Obtener el NSocio (ID del cliente) a partir del DNI
            int nSocio = gestionPago.ObtenerNSocioPorDNI(dniCliente);
            if (nSocio == 0)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }
            string nombreCliente = gestionPago.ObtenerNombreCliente(dniCliente);

            // Obtener la forma de pago y las cuotas
            string formaPago = optEfvo.Checked ? "Efectivo" : "Tarjeta";
            //int cuotas = rbTarjeta.Checked ? (rbTarjeta.Checked ? 3 : 6) : 1;

            // Calcular el monto total que debe pagar el cliente
            float montoTotal = gestionPago.CalcularMontoTotal(nSocio);

            // Crear instancia de la clase E_Pagar con los datos obtenidos
            E_Pagar pago = new E_Pagar
            {
                NCliente = nSocio,
                FormaPago = formaPago,
                //Cuotas = cuotas,
                Monto = montoTotal, // Utilizamos el monto total calculado
                FechaPago = DateTime.Now,
                NombreCliente = nombreCliente, // Asegúrate de agregar este campo a la clase E_Pagar

                
                ActividadesInscritas = pagoActual != null ? pagoActual.ActividadesInscritas : new List<string>()
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
                // Mostrar resultado con el nombre del cliente
                MessageBox.Show($"Pago realizado por {nombreCliente}: {resultado}");
            }
            else
            {
                // Mostrar resultado sin el nombre del cliente
                MessageBox.Show(resultado);
            }
            pago.NombreCliente = nombreCliente; // Asegúrate de agregar este campo a la clase E_Pagar
            pagoActual = pago;

            string actividadesLog = string.Join(", ", pago.ActividadesInscritas);
            Console.WriteLine("Actividades Inscritas en btnPagar_Click: " + actividadesLog);
            MessageBox.Show("Actividades Inscritas en btnPagar_Click: " + actividadesLog); // Log para depuración

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }


        

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            //E_Pagar pago = ObtenerDatosDelPago();

            //if (pagoActual != null)
            if (pagoActual != null && pagoActual.ActividadesInscritas != null)
            {
               
                Console.WriteLine("Actividades Inscritas en btnComprobante_Click: " );
                MessageBox.Show("Actividades Inscritas en btnComprobante_Click: " );
                // List<string> actividades = pagoActual.ActividadesInscritas.Split(',').ToList();

                FrmFactura frmFactura = new FrmFactura(
                    DateTime.Now,
                    pagoActual.NombreCliente,
                     //pagoActual.ActividadesInscritas ?? new List<string>(),

                    pagoActual.ActividadesInscritas,
                    pagoActual.FechaPago.AddMonths(1),
                 
                    pagoActual.FormaPago,
                    pagoActual.Monto
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

