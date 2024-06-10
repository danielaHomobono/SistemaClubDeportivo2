using SistemaClubDeportivo2.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SistemaClubDeportivo2.Datos
{
    public class DatosProfesores
    {
        


        public List<E_Profesor> ObtenerProfesores()
        {
            List<E_Profesor> listaProfesores = new List<E_Profesor>();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT NProfesor, NombreP, ApellidoP, TDocP, DocP, DomiP FROM profesor", sqlCon);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        E_Profesor profesor = new E_Profesor
                        {
                            NProfesor = reader.GetInt32(0),
                            NombreP = reader.GetString(1),
                            ApellidoP = reader.GetString(2),
                            TDocP = reader.GetString(3),
                            DocP = reader.GetInt32(4),
                            DomiP = reader.GetString(5)
                        };
                        listaProfesores.Add(profesor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return listaProfesores;
        }
    }
}
