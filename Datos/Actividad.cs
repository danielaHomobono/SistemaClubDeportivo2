using MySql.Data.MySqlClient;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClubDeportivo2.Datos
{
    internal class Actividad
    {
        public string Nueva_Actividad(E_Actividad actividad)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("NuevaActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = actividad.Nombre;
                comando.Parameters.Add("Cupo", MySqlDbType.Int32).Value = actividad.Cupo;
                comando.Parameters.Add("Precio", MySqlDbType.Float).Value = actividad.Precio;
                comando.Parameters.Add("NProf", MySqlDbType.Int32).Value = actividad.NProfesor;
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return salida;
        }
    }
}

