using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaClubDeportivo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Ingrese su Usuario";
            txtPass.Text = "Ingrese su Contraseña";
            txtUsuario.ForeColor = Color.Gray;
            txtPass.ForeColor = Color.Gray;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Ingrese su Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Ingrese su Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "Ingrese su Contraseña";
                txtPass.ForeColor = Color.Gray;
            }
        }

       private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el  usuario EXISTE
            MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
    }
}
