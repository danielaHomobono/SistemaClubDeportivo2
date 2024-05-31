using MySql.Data.MySqlClient;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Data;

namespace SistemaClubDeportivo2.Datos
{
    internal class Pagar
    {
        public string RealizarPago(E_Pagar pago)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("RegistrarPago", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("NSocio", MySqlDbType.Int32).Value = pago.NSocio;
                comando.Parameters.Add("FormaPago", MySqlDbType.VarChar).Value = pago.FormaPago;
                comando.Parameters.Add("Cuotas", MySqlDbType.Int32).Value = pago.Cuotas;
                comando.Parameters.Add("Monto", MySqlDbType.Float).Value = pago.Monto;
                comando.Parameters.Add("FechaPago", MySqlDbType.Date).Value = pago.FechaPago;
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = "Pago registrado correctamente";
            }
            catch (Exception ex)
            {
                salida = "Error al registrar el pago: " + ex.Message;
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
