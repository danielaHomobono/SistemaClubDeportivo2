using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Cursor;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.X509;
using SistemaClubDeportivo2.Datos;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SistemaClubDeportivo2
{
    public partial class InscribirActividad : Form
    {
        public InscribirActividad()
        {
            InitializeComponent();
            Load += new EventHandler(frmAsignar_Load);
        }

        private void frmAsignar_Load(object sender, EventArgs e)
        {
            CargaGrilla(); // Llamada al procedimiento
        }

        public void CargaGrilla()
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT c.Nombre AS Nombre_Actividad, s.fecha AS Fecha, CONCAT(p.NombreP, ' ', p.ApellidoP) AS Nombre_Profesor, c.precio AS Precio FROM actividad c INNER JOIN sesion s ON c.NActividad = s.NActividad INNER JOIN profesor p ON c.NProfesor = p.NProfesor WHERE s.fecha > CURDATE() ORDER BY c.Nombre";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.CommandType = CommandType.Text;
                    sqlCon.Open();
                    MessageBox.Show("La conexión a la base de datos se abrió correctamente."); // Mensaje de diagnóstico
                    MySqlDataReader reader = comando.ExecuteReader();
                    int numFilas = 0; // Para contar el número de filas devueltas
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int renglon = dtgvDatos.Rows.Add();
                            dtgvDatos.Rows[renglon].Cells[0].Value = reader.GetString(0);
                            dtgvDatos.Rows[renglon].Cells[1].Value = reader.GetDateTime(1).ToString("dd/MM/yyyy"); // Aquí convertimos la fecha a string
                            dtgvDatos.Rows[renglon].Cells[2].Value = reader.GetString(2);
                            dtgvDatos.Rows[renglon].Cells[3].Value = reader.GetFloat(3).ToString();

                        }
                    }
                    else
                    {
                        MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                    }
                    MessageBox.Show("La consulta SQL devolvió " + numFilas + " filas."); // Mensaje de diagnóstico
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la grilla: " + ex.Message);
                }
            }
        }


        // private void btnBorra_Click(object sender, EventArgs e)
        // {
        //    dtgvDatos.Rows.RemoveAt(nro);
        //}
    }
}