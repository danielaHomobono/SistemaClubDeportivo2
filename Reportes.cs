using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            CargarClientesCuotaVenceHoy();
        }

        private void CargarClientesCuotaVenceHoy()
        {
            Pagar gestionPago = new Pagar();
            var sociosCuotaVenceHoy = gestionPago.ObtenerSociosCuotaVenceHoy();
            dtgvDatos.Rows.Clear();

            foreach (var socio in sociosCuotaVenceHoy)
            
            {  int renglon = dtgvDatos.Rows.Add();
            string[] nombreCompleto = socio.nombreCompleto.Split(' ');

            dtgvDatos.Rows[renglon].Cells[0].Value = nombreCompleto[0]; // Nombre
            dtgvDatos.Rows[renglon].Cells[1].Value = nombreCompleto.Length > 1 ? nombreCompleto[1] : ""; // Apellido

            // Verificar si fechaUltimoPago no es el valor predeterminado
            if (socio.fechaUltimoPago != default(DateTime))
            {
                dtgvDatos.Rows[renglon].Cells[3].Value = socio.fechaUltimoPago.ToShortDateString();
            }
            else
            {
                dtgvDatos.Rows[renglon].Cells[3].Value = "Sin Pago";
            }

            dtgvDatos.Rows[renglon].Cells[2].Value = socio.email; // Email
            dtgvDatos.Rows[renglon].Cells[4].Value = socio.montoCuota; // Monto de la cuota
        }
    }

        private void btnVolver(object sender, EventArgs e)
        {

            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void VOLVER_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
