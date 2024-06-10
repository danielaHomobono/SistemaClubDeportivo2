using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaClubDeportivo2.Entidades;
using SistemaClubDeportivo2.Datos;

namespace SistemaClubDeportivo2
{
    public partial class FrmProfesores : Form
    {
        public FrmProfesores()
        {
            InitializeComponent();            
            CargarProfesores();
            ConfigurarEncabezadosGrilla();
        }

        private void CargarProfesores()
        {
            DatosProfesores datosProfesores = new DatosProfesores();
            List<E_Profesor> listaProfesores = datosProfesores.ObtenerProfesores();
            dgtvProfesores.DataSource = listaProfesores;
        }
        private void ConfigurarEncabezadosGrilla()
        {
            dgtvProfesores.Columns["NProfesor"].HeaderText = "N° Profesor";
            dgtvProfesores.Columns["NombreP"].HeaderText = "Nombre";
            dgtvProfesores.Columns["ApellidoP"].HeaderText = "Apellido";
            dgtvProfesores.Columns["TDocP"].HeaderText = "Tipo de Documento";
            dgtvProfesores.Columns["DocP"].HeaderText = "Documento";
            dgtvProfesores.Columns["DomiP"].HeaderText = "Domicilio";
        }

    }
}
