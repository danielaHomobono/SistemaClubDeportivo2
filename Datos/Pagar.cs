using MySql.Data.MySqlClient;
using SistemaClubDeportivo2.Datos;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    public class Pagar
    {
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el NSocio: " + ex.Message);
                }
            }
            return nSocio;
        }

        public string ObtenerNombreCliente(int dniCliente)
        {
            string nombreCliente = "";
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT CONCAT(NombreC, ' ', ApellidoC) AS NombreCompleto FROM cliente WHERE DocC = @DocC";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@DocC", dniCliente);
                    sqlCon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreCliente = reader.GetString(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el nombre del cliente: " + ex.Message);
                }
            }
            return nombreCliente;
        }

        public float CalcularMontoTotal(int nSocio)
        {
            float montoTotal = 0;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT SUM(c.precio) " +
                                   "FROM actividad c " +
                                   "INNER JOIN sesion s ON c.NActividad = s.NActividad " +
                                   "INNER JOIN inscripcion i ON s.idSesion = i.idSesion " +
                                   "WHERE i.NCliente = @NCliente AND s.fecha > CURDATE()";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@NCliente", nSocio);
                    sqlCon.Open();

                    montoTotal = Convert.ToSingle(comando.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al calcular el monto total: " + ex.Message);
                }
            }
            return montoTotal;
        }

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
                    if (result != DBNull.Value)
                    {
                        ultimoID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el último ID de pago: " + ex.Message);
                }
            }
            return ultimoID;
        }
        public int ObtenerIdInscripcion(int nSocio)
        {
            int idInscri = 0;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT idInscri FROM inscripcion WHERE NCliente = @NCliente";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@NCliente", nSocio);
                    sqlCon.Open();

                    object result = comando.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        idInscri = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el idInscri: " + ex.Message);
                }
            }
            return idInscri;
        }


        public string RealizarPago(E_Pagar pago)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "INSERT INTO pago (idInscri, monto, fecha) VALUES (@idInscri, @monto, @fecha)";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@idInscri", pago.IdInscri);
                    comando.Parameters.AddWithValue("@monto", pago.Monto);
                    comando.Parameters.AddWithValue("@fecha", pago.FechaPago);
                    sqlCon.Open();

                    comando.ExecuteNonQuery();
                    return "Pago realizado con éxito.";
                }
                catch (Exception ex)
                {
                    return "Error al realizar el pago: " + ex.Message;
                }
            }
        }
        public List<string> ObtenerActividadesInscritas(int nSocio)
        {
            List<string> actividades = new List<string>();
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = @"
                SELECT a.Nombre
                FROM actividad a
                INNER JOIN sesion s ON a.NActividad = s.NActividad
                INNER JOIN inscripcion i ON s.idSesion = i.idSesion
                WHERE i.NCliente = @NCliente AND s.fecha > CURDATE()";

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@NCliente", nSocio);
                    sqlCon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            actividades.Add(reader.GetString("Nombre"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener las actividades inscritas: " + ex.Message);
                }
            }
            return actividades;
        }

    }
}
