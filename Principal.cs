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

        internal string? rol;
        internal string? usuario;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            FrmInscripcion inscripcion = new FrmInscripcion();
            inscripcion.Show();
            this.Hide();
        }

        private void btnActividad_Click(object sender, EventArgs e)
        {
            InscribirActividad inscribirActividad = new InscribirActividad();
            inscribirActividad.Show();
            this.Hide();
            /* int clienteId = ObtenerClienteId(); // Método ficticio para obtener el clienteId
             InscribirActividad inscribirActividad = new InscribirActividad(clienteId);
             inscribirActividad.Show();
             this.Hide();*/
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FrmPagar frmPagar = new FrmPagar();
            frmPagar.Show();
            this.Hide();


        }
        // FrmPagar frmPagar = new FrmPagar();
        //frmPagar.Show();
        //this.Hide();


        private int ObtenerClienteId()
        {
            // Aquí debes implementar la lógica para obtener el clienteId
            // Esto puede ser a través de una consulta a la base de datos,
            // desde un formulario previo, etc.
            // Por ahora, usaremos un valor de ejemplo.
            return 1; // Valor de ejemplo, deberías obtener el clienteId real aquí
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmPrincipal));
            lblIngreso = new Label();
            btnSalir = new Button();
            btnInscribir = new Button();
            btnActividad = new Button();
            btnPagar = new Button();
            btnCarnet = new Button();
            pictureBox1 = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.BackColor = SystemColors.Control;
            lblIngreso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreso.ForeColor = SystemColors.ControlDarkDark;
            lblIngreso.Location = new Point(1, 9);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(0, 15);
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
            btnInscribir.BackColor = SystemColors.MenuHighlight;
            btnInscribir.Location = new Point(64, 319);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(203, 69);
            btnInscribir.TabIndex = 2;
            btnInscribir.Text = "Inscribir Cliente";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnActividad
            // 
            btnActividad.BackColor = SystemColors.MenuHighlight;
            btnActividad.Location = new Point(288, 319);
            btnActividad.Name = "btnActividad";
            btnActividad.Size = new Size(203, 69);
            btnActividad.TabIndex = 3;
            btnActividad.Text = "Inscribir Actividad";
            btnActividad.UseVisualStyleBackColor = false;
            btnActividad.Click += btnActividad_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.MenuHighlight;
            btnPagar.Location = new Point(64, 403);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(203, 69);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar Cuota";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = SystemColors.MenuHighlight;
            btnCarnet.Location = new Point(288, 403);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(203, 69);
            btnCarnet.TabIndex = 5;
            btnCarnet.Text = "Generar Carnet";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            ClientSize = new Size(557, 520);
            Controls.Add(pictureBox1);
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
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblIngreso;
        private Button btnSalir;
        private Button btnInscribir;
        private Button btnActividad;
        private Button btnPagar;
        private Button btnCarnet;
        private PictureBox pictureBox1;

        private void btnInscribir_Click_1(object sender, EventArgs e)
        {
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
        }
    }
}
