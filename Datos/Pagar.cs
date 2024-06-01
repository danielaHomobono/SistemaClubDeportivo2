using MySql.Data.MySqlClient;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Data;

namespace SistemaClubDeportivo2.Datos
{
    internal class Pagar
    {
        public int ObtenerUltimoIDPago()
        {
            int ultimoID = 0;
            // Implementa lógica para obtener el último ID de pago
            // desde la base de datos y devolverlo
            return ultimoID;
        }
        public int ObtenerNSocioPorDNI(int dniCliente)
        {
            int nSocio = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("ObtenerNSocioPorDNI", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@DNI", dniCliente);
                sqlCon.Open();
                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    nSocio = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el NSocio: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return nSocio;
        }

        public float CalcularMontoTotal(int nSocio)
        {
            float montoTotal = 0;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("CalcularMontoTotal", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NSocio", nSocio);
                sqlCon.Open();
                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    montoTotal = Convert.ToSingle(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al calcular el monto total: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return montoTotal;
        }


        public string RealizarPago(E_Pagar pago)
        {
            string salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("RegistrarPago", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NSocio", pago.NSocio);
                comando.Parameters.AddWithValue("@FormaPago", pago.FormaPago);
                comando.Parameters.AddWithValue("@Cuotas", pago.Cuotas);
                comando.Parameters.AddWithValue("@Monto", pago.Monto);
                comando.Parameters.AddWithValue("@FechaPago", pago.FechaPago);
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
