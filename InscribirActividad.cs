using MySql.Data.MySqlClient;
using SistemaClubDeportivo2.Datos;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    public partial class InscribirActividad : Form
    {
        private int NCliente;

        public InscribirActividad(int clienteId)
        {
            InitializeComponent();
            NCliente = clienteId;            
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
                    string query = "SELECT c.Nombre AS Nombre_Actividad, s.fecha AS Fecha, CONCAT(p.NombreP, ' ', p.ApellidoP) AS Nombre_Profesor, c.precio AS Precio, s.idSesion " +
                                   "FROM actividad c " +
                                   "INNER JOIN sesion s ON c.NActividad = s.NActividad " +
                                   "INNER JOIN profesor p ON c.NProfesor = p.NProfesor " +
                                   "WHERE s.fecha > CURDATE() " +
                                   "ORDER BY c.Nombre";
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
                            dtgvDatos.Rows[renglon].Cells[1].Value = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                            dtgvDatos.Rows[renglon].Cells[2].Value = reader.GetString(2);
                            dtgvDatos.Rows[renglon].Cells[3].Value = reader.GetFloat(3).ToString();
                            dtgvDatos.Rows[renglon].Cells[4].Value = reader.GetInt32(4); // Hidden column for session ID
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la grilla: " + ex.Message);
                }
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (dtgvDatos.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dtgvDatos.SelectedRows[0].Index;
                int idSesion = Convert.ToInt32(dtgvDatos.Rows[selectedRowIndex].Cells[4].Value);

                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
                {
                    try
                    {
                        string query = "INSERT INTO inscripcion (NCliente, idSesion, fecha) VALUES (@NCliente, @idSesion, @fecha)";
                        MySqlCommand comando = new MySqlCommand(query, sqlCon);
                        comando.Parameters.AddWithValue("@NCliente", NCliente);
                        comando.Parameters.AddWithValue("@idSesion", idSesion);
                        comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                        sqlCon.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cliente inscrito correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al inscribir al cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una actividad de la lista");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
