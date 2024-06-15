using SistemaClubDeportivo2.Entidades;
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
            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            E_Pagar pago = new E_Pagar();

            FrmPagar frmPagar = new FrmPagar(pago);
            frmPagar.Show();
            this.Hide();


        }
        


        private int ObtenerClienteId()
        {
            
            return 1; 
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de reportes
            Reportes formReportes = new Reportes();

            // Mostrar el formulario de reportes
            formReportes.Show();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmPrincipal));
            lblIngreso = new Label();
            btnSalir = new Button();
            btnInscribir = new Button();
            btnActividad = new Button();
            btnPagar = new Button();
            btnReportes = new Button();
            pictureBox1 = new PictureBox();
            btnProfesores = new Button();
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
            lblIngreso.Size = new Size(0, 20);
            lblIngreso.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.MenuHighlight;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ControlDarkDark;
            btnSalir.Location = new Point(766, 12);
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
            btnActividad.Size = new Size(253, 69);
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
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.MenuHighlight;
            btnReportes.Location = new Point(319, 403);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(203, 69);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(306, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnProfesores
            // 
            btnProfesores.BackColor = SystemColors.ActiveCaption;
            btnProfesores.Location = new Point(638, 359);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(203, 69);
            btnProfesores.TabIndex = 7;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = false;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // frmPrincipal
            // 
            ClientSize = new Size(870, 568);
            Controls.Add(btnProfesores);
            Controls.Add(pictureBox1);
            Controls.Add(btnReportes);
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
        private Button btnReportes;
        private PictureBox pictureBox1;
        private Button btnProfesores;

        
        
            private void btnProfesores_Click(object sender, EventArgs e)
            {
                // Crear una instancia del formulario de profesores
                FrmProfesores frmProfesores = new FrmProfesores();

                // Mostrar el formulario de profesores
                frmProfesores.Show();
                this.Hide();
            }
        }
    }

