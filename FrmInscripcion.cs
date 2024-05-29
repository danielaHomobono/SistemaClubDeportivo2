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
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
            txtDocumento.Text == "" || cboTipo.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Clientes cliente = new E_Clientes();
                cliente.NombreC = txtNombre.Text;
                cliente.ApellidoC = txtApellido.Text;
                cliente.DocC = Convert.ToInt32(txtDocumento.Text);

                // instanciamos para usar el metodo dentro de postulantes
                // Datos.Clientes clientes = new Datos.Clientes();
                SistemaClubDeportivo2.Entidades.Clientes clientes = new SistemaClubDeportivo2.Entidades.Clientes();
                respuesta = clientes.Nuevo_Cliente(cliente);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Question);



                        CheckBox chkSocio = this.Controls.Find("chkSocio", true).FirstOrDefault() as CheckBox;
                        if (chkSocio.Checked)//chkSocio != null &&// chkSocio.Checked)
                        {
                            string respuestaSocio = clientes.Nuevo_Socio(codigo);
                            if (int.TryParse(respuestaSocio, out int codigoSocio) && codigoSocio != -1)
                            {
                                MessageBox.Show("Se registró como socio con éxito con el código Nro " + respuestaSocio, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);


                                FrmImprimirCarnet imprimirCarnet = new FrmImprimirCarnet(cliente.NombreC, cliente.ApellidoC, cliente.DocC.ToString(), respuesta);

                                imprimirCarnet.Show();
                                this.Hide();

                            }

                            else
                            {
                                MessageBox.Show("Error al registrar como socio: " + respuestaSocio, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
            }
        }
            /* ===================================================
            * Limpiamos los objetos para un nuevo ingreso
            * ================================================ */
            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDocumento.Text = "";
                cboTipo.Text = "";
                txtNombre.Focus();
            }

            private void btnIngresarSocio_Click(object sender, EventArgs e)
            {

            }
        }
    }


    

