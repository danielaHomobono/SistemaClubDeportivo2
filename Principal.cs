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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();


        }

        /* ___________ VARIABLES tipo INTERNAL
        __________________________________
        * Serán accesibles desde el ensamblado en el cual están declarados
        * y tampoco se pueden utilizar en el interior de una función.
        ____________________________________________________________________ */
        internal string? rol;
        internal string? usuario;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            /* Notifica a todos los surtidores de mensajes que deben
            terminar
            * y, a continuación, cierra todas las ventanas de la
            aplicación
            *
            ____________________________________________________________
            __________ */
            Application.Exit();
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            FrmInscripcion inscripcion = new FrmInscripcion();
            inscripcion.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            lblIngreso = new Label();
            btnSalir = new Button();
            btnInscribir = new Button();
            btnActividad = new Button();
            btnPagar = new Button();
            btnCarnet = new Button();
            lbl = new Label();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.BackColor = SystemColors.ActiveCaption;
            lblIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreso.ForeColor = SystemColors.ControlDarkDark;
            lblIngreso.Location = new Point(12, 18);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(25, 20);
            lblIngreso.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.MenuHighlight;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ControlDarkDark;
            btnSalir.Location = new Point(461, 9);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 38);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = SystemColors.ControlDarkDark;
            btnInscribir.Location = new Point(64, 121);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(203, 69);
            btnInscribir.TabIndex = 2;
            btnInscribir.Text = "Inscribir Cliente";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnActividad
            // 
            btnActividad.BackColor = SystemColors.ControlDarkDark;
            btnActividad.Location = new Point(288, 121);
            btnActividad.Name = "btnActividad";
            btnActividad.Size = new Size(203, 69);
            btnActividad.TabIndex = 3;
            btnActividad.Text = "Inscribir Actividad";
            btnActividad.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.ControlDarkDark;
            btnPagar.Location = new Point(64, 212);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(203, 69);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar Cuota";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = SystemColors.ControlDarkDark;
            btnCarnet.Location = new Point(288, 212);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(203, 69);
            btnCarnet.TabIndex = 5;
            btnCarnet.Text = "Generar Carnet";
            btnCarnet.UseVisualStyleBackColor = false;
            // 
            // lbl
            // 
            lbl.Location = new Point(0, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(100, 23);
            lbl.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            ClientSize = new Size(564, 375);
            Controls.Add(lbl);
            Controls.Add(btnCarnet);
            Controls.Add(btnPagar);
            Controls.Add(btnActividad);
            Controls.Add(btnInscribir);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblIngreso;
        private Button btnSalir;
        private Button btnInscribir;
        private Button btnActividad;
        private Button btnPagar;
        private Button btnCarnet;

        private void btnInscribir_Click_1(object sender, EventArgs e)
        {

        }


        private Label lbl;
    }
}

