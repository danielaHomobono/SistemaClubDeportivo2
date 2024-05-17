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
            SuspendLayout();
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            lblIngresar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblIngresar.Location = new System.Drawing.Point(226, 20);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new System.Drawing.Size(179, 23);
            lblIngresar.TabIndex = 0;
            lblIngresar.Text = "REGISTRO DE CLIENTE";
            lblIngresar.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblNombre.Location = new System.Drawing.Point(167, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(254, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(296, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblApellido.Location = new System.Drawing.Point(167, 171);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(67, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(254, 172);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(296, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTipo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblTipo.Location = new System.Drawing.Point(94, 247);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(40, 20);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDni.Location = new System.Drawing.Point(303, 247);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(33, 20);
            lblDni.TabIndex = 6;
            lblDni.Text = "Dni";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(376, 247);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(250, 23);
            txtDocumento.TabIndex = 8;
            txtDocumento.TextChanged += textBox3_TextChanged;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "LC", "LE" });
            cboTipo.Location = new System.Drawing.Point(140, 247);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new System.Drawing.Size(121, 23);
            cboTipo.TabIndex = 9;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnIngresar.Location = new System.Drawing.Point(140, 332);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(107, 32);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = System.Drawing.SystemColors.Highlight;
            btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnLimpiar.Location = new System.Drawing.Point(275, 332);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(107, 32);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.SystemColors.Highlight;
            btnVolver.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnVolver.Location = new System.Drawing.Point(407, 332);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(107, 32);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(665, 450);
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
            ForeColor = System.Drawing.SystemColors.ControlDark;
            Name = "FrmInscripcion";
            Text = "FrmInscripcion";
            Load += FrmInscripcion_Load;
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
    }
}