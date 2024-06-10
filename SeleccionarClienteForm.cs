using SistemaClubDeportivo2.Entidades;
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
    public partial class SeleccionarClienteForm : Form
    {
        private List<E_Pagar> clientes;
        public SeleccionarClienteForm(List<E_Pagar> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
            CargarClientes();
        }

        private void CargarClientes()
        {
            listBoxClientes.Items.Clear();
            foreach (var cliente in clientes)
            {
                listBoxClientes.Items.Add(cliente.NombreCliente);
            }
        }

        public int ObtenerIdClienteSeleccionado()
        {
            if (listBoxClientes.SelectedIndex != -1)
            {
                return clientes[listBoxClientes.SelectedIndex].NCliente;
            }
            else
            {
                return -1; // Indica que no se ha seleccionado ningún cliente
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
/*namespace SistemaClubDeportivo2
{
    public partial class SeleccionarClienteForm : Form
    {
        private List<E_Pagar> clientes;
        public SeleccionarClienteForm(List<E_Pagar> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
            CargarClientes();
        }
        private void CargarClientes()
        {
            foreach (var cliente in clientes)
            {
                listBoxClientes.Items.Add(cliente.NombreCliente);
            }
        }

        public int ObtenerIdClienteSeleccionado()
        {
            if (listBoxClientes.SelectedIndex != -1)
            {
                return clientes[listBoxClientes.SelectedIndex].NCliente;
            }
            else
            {
                return -1; // Indica que no se ha seleccionado ningún cliente
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}*/
