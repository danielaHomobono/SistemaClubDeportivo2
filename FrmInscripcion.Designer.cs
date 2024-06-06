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
            chkPresentoFicha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlDarkDark;
            lblNombre.Location = new Point(191, 153);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(86, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(290, 149);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(338, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = SystemColors.ControlDarkDark;
            lblApellido.Location = new Point(191, 228);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(86, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(290, 229);
            txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(338, 27);
            txtApellido.TabIndex = 4;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = SystemColors.ControlDarkDark;
            lblTipo.Location = new Point(107, 329);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(52, 25);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = SystemColors.ControlDarkDark;
            lblDni.Location = new Point(346, 329);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 6;
            lblDni.Text = "Dni";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(430, 329);
            txtDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(285, 27);
            txtDocumento.TabIndex = 8;
            txtDocumento.TextChanged += textBox3_TextChanged;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "LC", "LE" });
            cboTipo.Location = new Point(160, 329);
            cboTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(138, 28);
            cboTipo.TabIndex = 9;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.Highlight;
            btnIngresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(31, 412);
            btnIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(122, 43);
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
            btnLimpiar.Location = new Point(191, 412);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(122, 43);
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
            btnVolver.Location = new Point(346, 412);
            btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(122, 43);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 140);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 169);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblObligatorio
            // 
            lblObligatorio.AutoSize = true;
            lblObligatorio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblObligatorio.ForeColor = Color.Red;
            lblObligatorio.Location = new Point(635, 137);
            lblObligatorio.Name = "lblObligatorio";
            lblObligatorio.Size = new Size(29, 37);
            lblObligatorio.TabIndex = 14;
            lblObligatorio.Text = "*";
            // 
            // lblObligatorio1
            // 
            lblObligatorio1.AutoSize = true;
            lblObligatorio1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblObligatorio1.ForeColor = Color.Red;
            lblObligatorio1.Location = new Point(635, 220);
            lblObligatorio1.Name = "lblObligatorio1";
            lblObligatorio1.Size = new Size(29, 37);
            lblObligatorio1.TabIndex = 15;
            lblObligatorio1.Text = "*";
            // 
            // lblObligatorio2
            // 
            lblObligatorio2.AutoSize = true;
            lblObligatorio2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblObligatorio2.ForeColor = Color.Red;
            lblObligatorio2.Location = new Point(305, 316);
            lblObligatorio2.Name = "lblObligatorio2";
            lblObligatorio2.Size = new Size(29, 37);
            lblObligatorio2.TabIndex = 16;
            lblObligatorio2.Text = "*";
            // 
            // lblObligatorio3
            // 
            lblObligatorio3.AutoSize = true;
            lblObligatorio3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblObligatorio3.ForeColor = Color.Red;
            lblObligatorio3.Location = new Point(722, 320);
            lblObligatorio3.Name = "lblObligatorio3";
            lblObligatorio3.Size = new Size(29, 37);
            lblObligatorio3.TabIndex = 17;
            lblObligatorio3.Text = "*";
            // 
            // chkSocio
            // 
            chkSocio.AutoSize = true;
            chkSocio.ForeColor = SystemColors.ActiveCaptionText;
            chkSocio.Location = new Point(535, 412);
            chkSocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chkSocio.Name = "chkSocio";
            chkSocio.Size = new Size(141, 24);
            chkSocio.TabIndex = 19;
            chkSocio.Text = "Desea ser socio?";
            chkSocio.UseVisualStyleBackColor = true;
            // 
            // chkPresentoFicha
            // 
            chkPresentoFicha.AutoSize = true;
            chkPresentoFicha.ForeColor = SystemColors.ActiveCaptionText;
            chkPresentoFicha.Location = new Point(535, 381);
            chkPresentoFicha.Name = "chkPresentoFicha";
            chkPresentoFicha.Size = new Size(220, 24);
            chkPresentoFicha.TabIndex = 20;
            chkPresentoFicha.Text = "Presentó ficha y Apto Físico?";
            chkPresentoFicha.UseVisualStyleBackColor = true;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(819, 537);
            Controls.Add(chkPresentoFicha);
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
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmInscripcion";
            Text = "FrmInscripcion";
            Load += FrmInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbIlngresar;
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
        private System.Windows.Forms.CheckBox chkPresentoFicha;
    }
}