using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            CargarSociosCuotaVenceHoy();
        }

        private void CargarSociosCuotaVenceHoy()
        {
            Pagar gestionPago = new Pagar();
            List<string> sociosCuotaVenceHoy = gestionPago.ObtenerSociosCuotaVenceHoy();
            dtgvDatos.Rows.Clear();

            foreach (string nombreCompleto in sociosCuotaVenceHoy)
            {
                int renglon = dtgvDatos.Rows.Add();
                string[] nombreApellido = nombreCompleto.Split(' ');

                // Asignar el nombre completo a la primera celda y dejar la segunda celda en blanco
                dtgvDatos.Rows[renglon].Cells[0].Value = nombreApellido[0]; // NombreC
                dtgvDatos.Rows[renglon].Cells[1].Value = nombreApellido.Length > 1 ? nombreApellido[1] : ""; // ApellidoC
            }
        }
    }
}
