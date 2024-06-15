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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaClubDeportivo2
{
    public partial class FrmInscripcion : Form
    {
        public FrmInscripcion()
        {
            InitializeComponent();

        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) &&
                !string.IsNullOrEmpty(txtDocumento.Text) && !string.IsNullOrEmpty(cboTipo.Text) &&
                !string.IsNullOrEmpty(txtEmail.Text))
            {
                E_Clientes cliente = new E_Clientes
                {
                    NombreC = txtNombre.Text,
                    ApellidoC = txtApellido.Text,
                    TDocC = cboTipo.Text,
                    DocC = Convert.ToInt32(txtDocumento.Text),
                    Email = txtEmail.Text
                };

                Datos.Clientes clientes = new Datos.Clientes();
                string respuesta = clientes.Nuevo_Cliente(cliente);

                if (respuesta == "1")
                {
                    MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool esnumero = int.TryParse(respuesta, out int codigo);
                    if (esnumero)
                    {
                        MessageBox.Show($"Se almacenó con éxito con el código Nro {respuesta}",
                            "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        // Verificar si se debe registrar como socio
                        if (chkSocio.Checked)
                        {
                            string respuestaSocio = clientes.Nuevo_Socio(codigo);
                            if (int.TryParse(respuestaSocio, out int codigoSocio) && codigoSocio != -1)
                            {
                                MessageBox.Show("Se registró como socio con éxito con el código Nro " + respuestaSocio,
                                    "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);

                                // Mostrar formulario de impresión de carnet
                                FrmImprimirCarnet imprimirCarnet = new FrmImprimirCarnet(cliente.NombreC, cliente.ApellidoC, cliente.DocC.ToString(), respuesta);
                                imprimirCarnet.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Error al registrar como socio: " + respuestaSocio,
                                    "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (!chkPresentoFicha.Checked)
                        {
                            MessageBox.Show("El cliente tiene pendiente presentar ficha y apto físico.",
                                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    else
                    {
                        MessageBox.Show($"Error al almacenar: {respuesta}", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.Text = "";
            txtEmail.Text = "";
            txtNombre.Focus();
        }

        private void btnIngresarSocio_Click(object sender, EventArgs e)
        {

        }

        private void lblObligatorio2_Click(object sender, EventArgs e)
        {

        }
    }
}


    

