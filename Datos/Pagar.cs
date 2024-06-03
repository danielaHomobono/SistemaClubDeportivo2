using MySql.Data.MySqlClient;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Data;
using System.Web;

namespace SistemaClubDeportivo2.Datos
{
    internal class Pagar
    {
        public int ObtenerUltimoIDPago()
        {
            int ultimoID = 0;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT MAX(idPago) FROM pago";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    sqlCon.Open();
                    object result = comando.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ultimoID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el último ID de pago: " + ex.Message);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
            return ultimoID;
        }
        public string ObtenerNombreCliente(int dniCliente)
        {
            string nombreCliente = string.Empty;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT CONCAT(NombreC, ' ', ApellidoC) AS NombreCompleto, NCliente FROM cliente WHERE DocC = @DocC"; 
                    //string query = "SELECT Nombre FROM cliente WHERE DocC = @DocC";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@DocC", dniCliente);
                    sqlCon.Open();
                    nombreCliente = comando.ExecuteScalar()?.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el nombre del cliente: " + ex.Message);
                }
            }
            return nombreCliente;
        }

        // Implementa lógica para obtener el último ID de pago
        // desde la base de datos y devolverlo




        /*public int ObtenerNSocioPorDNI(int dniCliente)
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
        }*/
        public int ObtenerNSocioPorDNI(int dniCliente)
        {
            int nSocio = 0;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT NCliente FROM cliente WHERE DocC = @DocC";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@DocC", dniCliente);
                    sqlCon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nSocio = reader.GetInt32(0);
                        }
                        else
                        {
                            Console.WriteLine("Cliente no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el NSocio: " + ex.Message);
                }
            }
            return nSocio;
        }

        /*public float CalcularMontoTotal(int nSocio)
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
        }*/
        public float CalcularMontoTotal(int nSocio)
        {
            float montoTotal = 0;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT MontoTotal FROM pagos WHERE NCliente = @NCliente";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@NCliente",nSocio );
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
                comando.Parameters.AddWithValue("@NCliente", pago.NCliente);
                //comando.Parameters.AddWithValue("@FormaPago", pago.FormaPago);
               // comando.Parameters.AddWithValue("@Cuotas", pago.Cuotas);
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
