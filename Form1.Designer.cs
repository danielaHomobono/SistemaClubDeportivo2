namespace SistemaClubDeportivo2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new System.Windows.Forms.Panel();
            lblTitulo = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            checkBox1mostar = new System.Windows.Forms.CheckBox();
            btnIngresar = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(398, 38);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            lblTitulo.Location = new System.Drawing.Point(118, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(144, 21);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "CLUB DEPORTIVO";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(118, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 123);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUsuario.Location = new System.Drawing.Point(67, 226);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(239, 22);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Ingrese su Usuario";
            txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPass
            // 
            txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPass.Location = new System.Drawing.Point(67, 288);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(239, 22);
            txtPass.TabIndex = 3;
            txtPass.Text = "Ingrese su Contraseña";
            txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // checkBox1mostar
            // 
            checkBox1mostar.AutoSize = true;
            checkBox1mostar.Location = new System.Drawing.Point(239, 316);
            checkBox1mostar.Name = "checkBox1mostar";
            checkBox1mostar.Size = new System.Drawing.Size(67, 19);
            checkBox1mostar.TabIndex = 4;
            checkBox1mostar.Text = "Mostrar";
            checkBox1mostar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngresar.ForeColor = System.Drawing.SystemColors.Window;
            btnIngresar.Location = new System.Drawing.Point(135, 367);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(108, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            ClientSize = new System.Drawing.Size(398, 477);
            Controls.Add(btnIngresar);
            Controls.Add(checkBox1mostar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox checkBox1mostar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblTitulo;
    }
}
