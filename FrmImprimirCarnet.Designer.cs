namespace SistemaClubDeportivo2
{
    partial class FrmImprimirCarnet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNumeroSocio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNumeroSocio;
        private System.Windows.Forms.Button btnVolver;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FrmImprimirCarnet";
        

        #endregion
       // private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNumeroSocio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNumeroSocio = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;

            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(150, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 1;

            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(150, 110);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(200, 20);
            this.txtDocumento.TabIndex = 2;

            // 
            // txtNumeroSocio
            // 
            this.txtNumeroSocio.Location = new System.Drawing.Point(150, 150);
            this.txtNumeroSocio.Name = "txtNumeroSocio";
            this.txtNumeroSocio.ReadOnly = true;
            this.txtNumeroSocio.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroSocio.TabIndex = 3;

            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";

            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(50, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";

            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(50, 110);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 6;
            this.lblDocumento.Text = "Documento:";

            // 
            // lblNumeroSocio
            // 
            this.lblNumeroSocio.AutoSize = true;
            this.lblNumeroSocio.Location = new System.Drawing.Point(50, 150);
            this.lblNumeroSocio.Name = "lblNumeroSocio";
            this.lblNumeroSocio.Size = new System.Drawing.Size(78, 13);
            this.lblNumeroSocio.TabIndex = 7;
            this.lblNumeroSocio.Text = "Número Socio:";

            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(150, 190);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            // 
            // FrmImprimirCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblNumeroSocio);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNumeroSocio);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmImprimirCarnet";
            this.Text = "Imprimir Carnet";
            this.Load += new System.EventHandler(this.FrmImprimirCarnet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        }

    }
}
    
