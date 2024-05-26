namespace SistemaClubDeportivo2
{
    partial class FrmFactura
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
            pnlComprobante = new System.Windows.Forms.Panel();
            lblClubD = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblDfecha = new System.Windows.Forms.Label();
            pnlDatos = new System.Windows.Forms.Panel();
            btnImprimir = new System.Windows.Forms.Button();
            lblCliente = new System.Windows.Forms.Label();
            lblActividad = new System.Windows.Forms.Label();
            lblDia = new System.Windows.Forms.Label();
            lblFPago = new System.Windows.Forms.Label();
            lblValor = new System.Windows.Forms.Label();
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
            pnlDatos.Controls.Add(lblValor);
            pnlDatos.Controls.Add(lblFPago);
            pnlDatos.Controls.Add(lblDia);
            pnlDatos.Controls.Add(lblActividad);
            pnlDatos.Controls.Add(lblCliente);
            pnlDatos.Location = new System.Drawing.Point(0, 185);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new System.Drawing.Size(799, 194);
            pnlDatos.TabIndex = 2;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new System.Drawing.Point(299, 406);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(75, 23);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new System.Drawing.Point(23, 22);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new System.Drawing.Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new System.Drawing.Point(23, 58);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new System.Drawing.Size(78, 15);
            lblActividad.TabIndex = 1;
            lblActividad.Text = "Se inscribe a :";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new System.Drawing.Point(23, 94);
            lblDia.Name = "lblDia";
            lblDia.Size = new System.Drawing.Size(38, 15);
            lblDia.TabIndex = 2;
            lblDia.Text = "Fecha";
            // 
            // lblFPago
            // 
            lblFPago.AutoSize = true;
            lblFPago.Location = new System.Drawing.Point(29, 124);
            lblFPago.Name = "lblFPago";
            lblFPago.Size = new System.Drawing.Size(87, 15);
            lblFPago.TabIndex = 3;
            lblFPago.Text = "Forma de pago";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new System.Drawing.Point(336, 124);
            lblValor.Name = "lblValor";
            lblValor.Size = new System.Drawing.Size(43, 15);
            lblValor.TabIndex = 4;
            lblValor.Text = "Monto";
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(pnlDatos);
            Controls.Add(panel1);
            Controls.Add(pnlComprobante);
            Name = "FrmFactura";
            Text = "FrmFactura";
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
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFPago;
    }
}