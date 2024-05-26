using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Cursor;
using SistemaClubDeportivo2.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SistemaClubDeportivo2
{
    public partial class InscribirActividad : Form
    {
        int nro;
        public InscribirActividad()
        {
            InitializeComponent();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked!"); // Confirmación de evento

            // Agregar un renglon para la escritura
            int renglon = dtgvDatos.Rows.Add();
            // Colocamos los datos en las columnas de esa fila
            dtgvDatos.Rows[renglon].Cells[0].Value = txtNombreAct.Text;
            dtgvDatos.Rows[renglon].Cells[1].Value = txtFecha.Text;
            dtgvDatos.Rows[renglon].Cells[2].Value = txtProfesor.Text;
            dtgvDatos.Rows[renglon].Cells[3].Value = txtPrecio.Text;

            // Blanqueo de los textBox
            txtNombreAct.Text = "";
            txtFecha.Text = "";
            txtProfesor.Text = "";
            txtPrecio.Text = "";

            // El foco se instala en el objeto
            txtNombreAct.Focus();
        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nro = e.RowIndex; // Muestra la posición de la fila seleccionada
            if (nro != -1)
            {
                MessageBox.Show((string)dtgvDatos.Rows[nro].Cells[1].Value);
            }
            else
            {
                MessageBox.Show("Seleccionó el ENCABEZADO");
            }
        }

        private void frmAsignar_Load(object sender, EventArgs e)
        {
            CargaGrilla(); // Llamada al procedimiento
        }

        public void CargaGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConcexion();
                query = "SELECT a.Nombre, s.fecha, CONCAT(pr.NombreP, ' ', pr.ApellidoP) AS NombreCompleto, s.precio " +
                        "FROM actividad a " +
                        "INNER JOIN sesion s ON a.NActividad = s.NActividad " +
                        "INNER JOIN inscripcion i ON s.idSesion = i.idSesion " +
                        "INNER JOIN socio so ON i.NSocio = so.NSocio " +
                        "INNER JOIN cliente cl ON i.NCliente = cl.NCliente " +
                        "INNER JOIN profesor pr ON a.NProfesor = pr.NProfesor " +
                        "WHERE s.fecha > CURDATE() ORDER BY a.Nombre";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvDatos.Rows.Add();
                        dtgvDatos.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvDatos.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvDatos.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvDatos.Rows[renglon].Cells[3].Value = reader.GetString(3);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            dtgvDatos.Rows.RemoveAt(nro);
        }
    }
}