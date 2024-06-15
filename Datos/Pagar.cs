using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Bcpg.OpenPgp;
using SistemaClubDeportivo2.Datos;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public float CalcularMontoTotal(int nSocio, bool esSocio, bool esCuotaMensual, int cuotas = 1)
        //public float CalcularMontoTotal(int nSocio, bool esSocio, bool esPagoCuota, bool esCuotaMensual, int cuotas = 1)
        {
            float montoTotal = 0;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    sqlCon.Open();
                    MySqlCommand comando;

                    if (esSocio)
                    {
                        //montoTotal = esCuotaMensual ? 2000 : 100;
                        montoTotal = 2000;
                    }
                    else
                    {

                        string queryActividades = "SELECT SUM(c.precio) " +
                                                  "FROM actividad c " +
                                                  "INNER JOIN sesion s ON c.NActividad = s.NActividad " +
                                                  "INNER JOIN inscripcion i ON s.idSesion = i.idSesion " +
                                                  "WHERE i.NCliente = @NCliente AND s.fecha > CURDATE()";
                        comando = new MySqlCommand(queryActividades, sqlCon);
                        comando.Parameters.AddWithValue("@NCliente", nSocio);

                        //montoTotal = Convert.ToSingle(comando.ExecuteScalar());
                        object result = comando.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            montoTotal = Convert.ToSingle(result);
                        }
                    }
                    
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
                    string query = "SELECT idInscri FROM inscripcion WHERE NCliente = @NCliente OR NSocio = @NSocio";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@NCliente", nSocio);
                    comando.Parameters.AddWithValue("@NSocio", nSocio);
                    sqlCon.Open();



                    object result = comando.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idInscri = Convert.ToInt32(result);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró idInscri para NCliente/NSocio: " + nSocio); // Línea de depuración
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener el idInscri: " + ex.Message); // Línea de depuración
                }
            }
            return idInscri;
        }



        public bool EsSocio(int dniCliente)
        {
            bool esSocio = false;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = @"
                SELECT COUNT(*)
                FROM socio s
                JOIN cliente c ON s.NCliente = c.NCliente
                WHERE c.DocC = @DocC";

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@DocC", dniCliente);
                    sqlCon.Open();

                    Console.WriteLine("Consulta SQL en EsSocio: " + query);

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    esSocio = count > 0;

                    Console.WriteLine("Valor de esSocio en EsSocio: " + esSocio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar si el cliente es socio: " + ex.Message);
                    Console.WriteLine("Error al verificar si el cliente es socio: " + ex.Message);
                }
            }
            return esSocio;
        }
        public DateTime ObtenerFechaVencimiento(int nSocio)
        {
            DateTime fechaVencimiento = DateTime.MinValue;
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = @"
                SELECT MAX(p.fecha)
                FROM pago p
                INNER JOIN inscripcion i ON p.idInscri = i.idInscri
                WHERE i.NCliente = @NCliente";

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@NCliente", nSocio);
                    sqlCon.Open();

                    object result = comando.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        fechaVencimiento = Convert.ToDateTime(result).AddMonths(1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la fecha de vencimiento: " + ex.Message);
                }
            }
            return fechaVencimiento;
        }
        public string ObtenerTipoPago(int nSocio)
        {
            string tipoPago = "Actividad";
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = @"
                SELECT COUNT(*)
                FROM socio s
                JOIN cliente c ON s.NCliente = c.NCliente
                WHERE c.NCliente = @NCliente";

                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@NCliente", nSocio);
                    sqlCon.Open();

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    if (count > 0)
                    {
                        tipoPago = "Cuota de Socio";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el tipo de pago: " + ex.Message);
                }
            }
            return tipoPago;
        }





        public void ProcesarPago(int nSocio, E_Pagar pago)
        {
            // Obtener el ID de inscripción
            int idInscri = ObtenerIdInscripcion(nSocio);
            Console.WriteLine("ID de Inscripción: " + idInscri); // Línea de depuración

            // Asignar el ID de inscripción al objeto de pago
            pago.IdInscri = idInscri;

            // Realizar el pago
            string resultado = RealizarPago(pago);
            Console.WriteLine("Resultado del pago: " + resultado); // Línea de depuración

            // Mostrar el resultado del pago al usuario o realizar otras acciones necesarias
            MessageBox.Show(resultado);
        }








        public string RealizarPago(E_Pagar pago)
        {
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {

                    sqlCon.Open();
                    string query = "INSERT INTO pago (idPago, idInscri, monto, fecha, esCuotaMensual) " +
                           "VALUES (@IDPago, @IdInscri, @Monto, @FechaPago, @EsCuotaMensual)";


                    MySqlCommand comando = new MySqlCommand(query, sqlCon);

                    comando.Parameters.AddWithValue("@IDPago", pago.IDPago);
                    comando.Parameters.AddWithValue("@IdInscri", pago.IdInscri == 0 ? DBNull.Value : (object)pago.IdInscri); // Manejo de idInscri
                    comando.Parameters.AddWithValue("@Monto", pago.Monto);
                    comando.Parameters.AddWithValue("@FechaPago", pago.FechaPago);
                    comando.Parameters.AddWithValue("@EsCuotaMensual", pago.EsCuotaMensual ? 1 : 0);




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



        public List<(string nombreCompleto, DateTime fechaUltimoPago, string email, float montoCuota)> ObtenerSociosCuotaVenceHoy()
        {
            List<(string, DateTime, string, float)> sociosCuotaVenceHoy = new List<(string, DateTime, string, float)>();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = @"SELECT c.NombreC, c.ApellidoC, p.fecha AS FechaUltimoPago, c.Email, c.DocC
FROM cliente c
LEFT JOIN inscripcion i ON c.NCliente = i.NCliente
LEFT JOIN pago p ON i.idInscri = p.idInscri
WHERE(YEAR(p.fecha) = YEAR(CURDATE()) AND MONTH(p.fecha) = MONTH(CURDATE())) OR
      (YEAR(p.fecha) = YEAR(CURDATE()) AND MONTH(p.fecha) < MONTH(CURDATE())) OR
      p.fecha IS NULL";


                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    sqlCon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreCompleto = reader.GetString("NombreC") + " " + reader.GetString("ApellidoC");
                            string email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString("Email");
                            DateTime fechaUltimoPago = reader.IsDBNull(reader.GetOrdinal("FechaUltimoPago")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("FechaUltimoPago"));

                            int dniCliente = reader.GetInt32("DocC");
                            int nSocio = ObtenerNSocioPorDNI(dniCliente); // Obtener el NSocio a partir del DNI
                            bool esSocio = EsSocio(dniCliente); // Determinar si el cliente es socio

                            // Calcular el monto de la cuota en base a si es socio o no
                            float montoCuota = CalcularMontoTotal(nSocio, esSocio, true);

                            sociosCuotaVenceHoy.Add((nombreCompleto, fechaUltimoPago, email, montoCuota));

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los socios cuya cuota vence hoy: " + ex.Message);
                }
            }

            return sociosCuotaVenceHoy;
        }

    }
}

