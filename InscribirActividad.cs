﻿using MySql.Data.MySqlClient;
using SistemaClubDeportivo2.Datos;
using SistemaClubDeportivo2.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    public partial class InscribirActividad : Form
    {
        private int NCliente;
        private E_Pagar pagoActual;

        public InscribirActividad()
        {
            InitializeComponent();
            Load += new EventHandler(frmAsignar_Load);
        }

        private void frmAsignar_Load(object sender, EventArgs e)
        {
            CargaGrilla(); // Llamada al procedimiento

            // Permitir selección múltiple
            dtgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDatos.MultiSelect = true;
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

        public string ObtenerNombreClientePorDni(string dni)
        {
            string nombreCliente = "";
            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
            {
                try
                {
                    string query = "SELECT CONCAT(NombreC, ' ', ApellidoC) AS NombreCompleto, NCliente FROM cliente WHERE DocC = @DocC";
                    MySqlCommand comando = new MySqlCommand(query, sqlCon);
                    comando.Parameters.AddWithValue("@DocC", dni);
                    sqlCon.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreCliente = reader.GetString(0);
                            NCliente = reader.GetInt32(1);
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el cliente: " + ex.Message);
                }
            }
            return nombreCliente;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            if (!string.IsNullOrEmpty(dni))
            {
                string nombreCliente = ObtenerNombreClientePorDni(dni);
                if (!string.IsNullOrEmpty(nombreCliente))
                {
                    lblClienteNombre.Text = "Cliente: " + nombreCliente;
                }
                else
                {
                    lblClienteNombre.Text = "Cliente: ";
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI válido.");
            }
        }


        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (NCliente == 0)
            {
                MessageBox.Show("Debe buscar y seleccionar un cliente antes de inscribir.");
                return;
            }
            if (dtgvDatos.SelectedRows.Count > 0)
            {
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
                {
                    sqlCon.Open();
                    MySqlTransaction transaction = sqlCon.BeginTransaction();
                    try
                    {
                        List<string> actividadesInscritas = new List<string>();
                        float montoTotal = 0;

                        foreach (DataGridViewRow row in dtgvDatos.SelectedRows)
                        {
                            int idSesion = Convert.ToInt32(row.Cells[4].Value);
                            string nombreActividad = row.Cells[0].Value.ToString();
                            float precioActividad = Convert.ToSingle(row.Cells[3].Value);

                            // Verificar el cupo disponible
                            string queryCupo = "SELECT a.cupo - COUNT(i.idSesion) AS CupoDisponible " +
                                               "FROM actividad a " +
                                               "INNER JOIN sesion s ON a.NActividad = s.NActividad " +
                                               "LEFT JOIN inscripcion i ON s.idSesion = i.idSesion " +
                                               "WHERE s.idSesion = @idSesion " +
                                               "GROUP BY a.cupo";
                            MySqlCommand comandoCupo = new MySqlCommand(queryCupo, sqlCon, transaction);
                            comandoCupo.Parameters.AddWithValue("@idSesion", idSesion);
                            int cupoDisponible = Convert.ToInt32(comandoCupo.ExecuteScalar());

                            if (cupoDisponible > 0)
                            {
                                string query = "INSERT INTO inscripcion (NCliente, idSesion, fecha) VALUES (@NCliente, @idSesion, @fecha)";
                                MySqlCommand comando = new MySqlCommand(query, sqlCon, transaction);
                                comando.Parameters.AddWithValue("@NCliente", NCliente);
                                comando.Parameters.AddWithValue("@idSesion", idSesion);
                                comando.Parameters.AddWithValue("@fecha", DateTime.Now);

                                comando.ExecuteNonQuery();
                                actividadesInscritas.Add(nombreActividad);
                                montoTotal += precioActividad;
                            }
                            else
                            {
                                MessageBox.Show($"No hay cupo disponible para la actividad: {nombreActividad}");
                            }
                        }

                        transaction.Commit();

                        List<string> actividadesCliente = ObtenerActividadesCliente(NCliente);

                        pagoActual = new E_Pagar { ActividadesInscritas = actividadesCliente };

                        string actividades = string.Join(", ", actividadesCliente);
                        MessageBox.Show("Cliente inscrito correctamente en las siguientes actividades: " + actividades);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al inscribir al cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una o más actividades de la lista.");
            }
        }


        
        public List<string> ObtenerActividadesCliente(int nCliente)
         {
             List<string> actividadesCliente = new List<string>();
             using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConcexion())
             {
                 try
                 {
                     string query = "SELECT DISTINCT c.Nombre AS Nombre_Actividad " +
                                    "FROM actividad c " +
                                    "INNER JOIN sesion s ON c.NActividad = s.NActividad " +
                                    "INNER JOIN inscripcion i ON s.idSesion = i.idSesion " +
                                    "WHERE i.NCliente = @NCliente AND s.fecha > CURDATE()";
                     MySqlCommand comando = new MySqlCommand(query, sqlCon);
                     comando.Parameters.AddWithValue("@NCliente", nCliente);
                     sqlCon.Open();

                     using (MySqlDataReader reader = comando.ExecuteReader())
                     {
                         while (reader.Read())
                         {
                             actividadesCliente.Add(reader.GetString(0));
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error al obtener las actividades del cliente: " + ex.Message);
                 }
             }
             return actividadesCliente;
         }



         private void btnSalir_Click(object sender, EventArgs e)
         {
             this.Close();
         }
         private void btnVolver_Click(object sender, EventArgs e)
         {
             frmPrincipal principal = new frmPrincipal();
             principal.Show();
             this.Hide();
         }


    }
}



