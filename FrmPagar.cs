using SistemaClubDeportivo2;
using SistemaClubDeportivo2.Datos;
using MySql.Data.MySqlClient;
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
    public partial class FrmPagar : Form
    {
        public FrmFactura doc = new FrmFactura();

        public FrmPagar()
        {
            InitializeComponent();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
            this.Hide();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConcexion();
                
                 query =  "SELECT i.idInscri, a.Nombre AS NombreActividad, CONCAT(c.NombreC, ' ', c.ApellidoC) AS NombreCompleto, a.precio, s.fecha " +
                        "FROM inscripcion i " +
                        "INNER JOIN socio so ON i.NSocio = so.NSocio " +
                        "INNER JOIN cliente c ON so.NCliente = c.NCliente " +
                        "INNER JOIN sesion s ON i.idSesion = s.idSesion " +
                        "INNER JOIN actividad a ON s.NActividad = a.NActividad " +
                        "WHERE c.NCliente = " + txtNcliente.Text;//("select idinscri, nombre, concat(nombrep, '', apellidop), precio,e.fecha " +
                                                                //"from inscripcion i inner join edicion e on i.idEdicion = e.idEdicion" +
                                                                //" inner join curso c on c.ncurso = e.ncurso inner join alumno a on a.legajo = i.legajo" +
                                                                // " inner join postulante p on p.NPostu = a.Npostu where idinscri = " + txtNcliente.Text); // <<<------ usamos el dato ingresado

                MySqlCommand comando = new MySqlCommand(query,
                sqlCon);
                // usamos la consulta y la                conexion.-
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena   TODAS las filas.-
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si   tiene datos es UNA SOLA FILA
                    doc.numero_f = Convert.ToInt32(reader.GetString
                    (0));

                    doc.curso_f = reader.GetString(1);
                    doc.alumno_f = reader.GetString(2);
                    doc.monto_f = (float)Convert.ToDouble
                    (reader.GetString(3));
                    doc.fecha_f = (DateTime)Convert.ToDateTime
                    (reader.GetString(4));
                    if (optEfvo.Checked == true) // Evaluamos que opcion es la seleccionada
                    {
                        doc.forma_f = "Efectivo";
                        /* ---------------------------------
                        * Pago en efvo se descuenta 10%
                        * --------------------------------- */
                doc.monto_f = (float)(doc.monto_f * 0.90);
                    }
                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }
                    btnComprobante.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Número de inscripcion inexistente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            //private void FrmPagar_Load(object sender, EventArgs e)
            // {

            //}


        }

       
    }
}
