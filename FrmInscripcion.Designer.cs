using System.Drawing;
using System;

namespace SistemaClubDeportivo2
{
    partial class FrmInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscripcion));
            lblIngresar = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblApellido = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            lblTipo = new System.Windows.Forms.Label();
            lblDni = new System.Windows.Forms.Label();
            txtDocumento = new System.Windows.Forms.TextBox();
            cboTipo = new System.Windows.Forms.ComboBox();
            btnIngresar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblObligatorio = new System.Windows.Forms.Label();
            lblObligatorio1 = new System.Windows.Forms.Label();
            lblObligatorio2 = new System.Windows.Forms.Label();
            lblObligatorio3 = new System.Windows.Forms.Label();
            chkSocio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.BackColor = SystemColors.MenuHighlight;
            lblIngresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblIngresar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresar.ForeColor = SystemColors.ButtonHighlight;
            lblIngresar.Location = new Point(226, 20);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(236, 32);
            lblIngresar.TabIndex = 0;
            lblIngresar.Text = "REGISTRO DE CLIENTE";
            lblIngresar.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlDarkDark;
            lblNombre.Location = new Point(167, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(254, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(296, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ControlDarkDark;
            lblApellido.Location = new Point(167, 171);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(254, 172);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(296, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = SystemColors.ControlDarkDark;
            lblTipo.Location = new Point(94, 247);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 20);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlDarkDark;
            lblDni.Location = new Point(303, 247);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(33, 20);
            lblDni.TabIndex = 6;
            lblDni.Text = "Dni";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(376, 247);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(250, 23);
            txtDocumento.TabIndex = 8;
            txtDocumento.TextChanged += textBox3_TextChanged;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "LC", "LE" });
            cboTipo.Location = new Point(140, 247);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 9;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.Highlight;
            btnIngresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(27, 309);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(107, 32);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Highlight;
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(167, 309);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 32);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Highlight;
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ButtonHighlight;
            btnVolver.Location = new Point(303, 309);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 32);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 127);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblObligatorio
            // 
            lblObligatorio.AutoSize = true;
            lblObligatorio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblObligatorio.ForeColor = Color.Red;
            lblObligatorio.Location = new Point(556, 103);
            lblObligatorio.Name = "lblObligatorio";
            lblObligatorio.Size = new Size(23, 30);
            lblObligatorio.TabIndex = 14;
            lblObligatorio.Text = "*";
            // 
            // lblObligatorio1
            // 
            lblObligatorio1.AutoSize = true;
            lblObligatorio1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblObligatorio1.ForeColor = Color.Red;
            lblObligatorio1.Location = new Point(556, 165);
            lblObligatorio1.Name = "lblObligatorio1";
            lblObligatorio1.Size = new Size(23, 30);
            lblObligatorio1.TabIndex = 15;
            lblObligatorio1.Text = "*";
            // 
            // lblObligatorio2
            // 
            lblObligatorio2.AutoSize = true;
            lblObligatorio2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblObligatorio2.ForeColor = Color.Red;
            lblObligatorio2.Location = new Point(267, 237);
            lblObligatorio2.Name = "lblObligatorio2";
            lblObligatorio2.Size = new Size(23, 30);
            lblObligatorio2.TabIndex = 16;
            lblObligatorio2.Text = "*";
            // 
            // lblObligatorio3
            // 
            lblObligatorio3.AutoSize = true;
            lblObligatorio3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblObligatorio3.ForeColor = Color.Red;
            lblObligatorio3.Location = new Point(632, 240);
            lblObligatorio3.Name = "lblObligatorio3";
            lblObligatorio3.Size = new Size(23, 30);
            lblObligatorio3.TabIndex = 17;
            lblObligatorio3.Text = "*";
            // 
            // chkSocio
            // 
            chkSocio.AutoSize = true;
            chkSocio.ForeColor = SystemColors.ActiveCaptionText;
            chkSocio.Location = new Point(468, 309);
            chkSocio.Name = "chkSocio";
            chkSocio.Size = new Size(111, 19);
            chkSocio.TabIndex = 19;
            chkSocio.Text = "Desea ser socio?";
            chkSocio.UseVisualStyleBackColor = true;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(665, 403);
            Controls.Add(chkSocio);
            Controls.Add(lblObligatorio3);
            Controls.Add(lblObligatorio2);
            Controls.Add(lblObligatorio1);
            Controls.Add(lblObligatorio);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(lblDni);
            Controls.Add(lblTipo);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblIngresar);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "FrmInscripcion";
            Text = "FrmInscripcion";
            Load += FrmInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblObligatorio;
        private System.Windows.Forms.Label lblObligatorio1;
        private System.Windows.Forms.Label lblObligatorio2;
        private System.Windows.Forms.Label lblObligatorio3;
        private System.Windows.Forms.CheckBox chkSocio;
    }
}