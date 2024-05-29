namespace SistemaClubDeportivo2
{
    partial class FrmImprimirCarnet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlComprobante = new System.Windows.Forms.Panel();
            lblClubD = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblDfecha = new System.Windows.Forms.Label();
            pnlDatos = new System.Windows.Forms.Panel();
            txtNumeroSocio = new System.Windows.Forms.TextBox();
            txtDocumento = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            lblNumeroSocio = new System.Windows.Forms.Label();
            lblDocumento = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            btnImprimir = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlComprobante
            // 
            pnlComprobante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pnlComprobante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pnlComprobante.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            pnlComprobante.Location = new System.Drawing.Point(0, 0);
            pnlComprobante.Name = "pnlComprobante";
            pnlComprobante.Size = new System.Drawing.Size(799, 61);
            pnlComprobante.TabIndex = 0;
            // 
            // lblClubD
            // 
            lblClubD.AutoSize = true;
            lblClubD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lblClubD.Location = new System.Drawing.Point(12, 30);
            lblClubD.Name = "lblClubD";
            lblClubD.Size = new System.Drawing.Size(100, 15);
            lblClubD.TabIndex = 0;
            lblClubD.Text = "CLUB DEPORTIVO";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDfecha);
            panel1.Controls.Add(lblClubD);
            panel1.Location = new System.Drawing.Point(0, 67);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(799, 100);
            panel1.TabIndex = 1;
            // 
            // lblDfecha
            // 
            lblDfecha.AutoSize = true;
            lblDfecha.Location = new System.Drawing.Point(470, 12);
            lblDfecha.Name = "lblDfecha";
            lblDfecha.Size = new System.Drawing.Size(38, 15);
            lblDfecha.TabIndex = 1;
            lblDfecha.Text = "Fecha";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(txtNumeroSocio);
            pnlDatos.Controls.Add(txtDocumento);
            pnlDatos.Controls.Add(txtApellido);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblNumeroSocio);
            pnlDatos.Controls.Add(lblDocumento);
            pnlDatos.Controls.Add(lblApellido);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Location = new System.Drawing.Point(0, 185);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new System.Drawing.Size(799, 194);
            pnlDatos.TabIndex = 2;
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Location = new System.Drawing.Point(150, 130);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.ReadOnly = true;
            txtNumeroSocio.Size = new System.Drawing.Size(200, 23);
            txtNumeroSocio.TabIndex = 7;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(150, 94);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = true;
            txtDocumento.Size = new System.Drawing.Size(200, 23);
            txtDocumento.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(150, 58);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new System.Drawing.Size(200, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(150, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new System.Drawing.Size(200, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblNumeroSocio
            // 
            lblNumeroSocio.AutoSize = true;
            lblNumeroSocio.Location = new System.Drawing.Point(23, 130);
            lblNumeroSocio.Name = "lblNumeroSocio";
            lblNumeroSocio.Size = new System.Drawing.Size(83, 15);
            lblNumeroSocio.TabIndex = 3;
            lblNumeroSocio.Text = "Número Socio";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new System.Drawing.Point(23, 94);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new System.Drawing.Size(70, 15);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(23, 58);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(23, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new System.Drawing.Point(299, 406);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(75, 23);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // FrmImprimirCarnet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(pnlDatos);
            Controls.Add(panel1);
            Controls.Add(pnlComprobante);
            Name = "FrmImprimirCarnet";
            Text = "Imprimir Carnet";
            Load += FrmImprimirCarnet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlComprobante;
        private System.Windows.Forms.Label lblClubD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDfecha;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblNumeroSocio;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumeroSocio;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Timer transitionTimer = new System.Windows.Forms.Timer();

    }
}
