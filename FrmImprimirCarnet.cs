using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public FrmImprimirCarnet(string nombre, string apellido, string documento, string numeroSocio)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.numeroSocio = numeroSocio;
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            btnImprimir.Visible = false;
        }
        // public FrmImprimirCarnet()
        //{

        //}
    }
}
