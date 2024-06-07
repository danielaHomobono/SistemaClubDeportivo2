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
            lblFechaActual = new System.Windows.Forms.Label();
            lblNombreCliente = new System.Windows.Forms.Label();
            lblActividadesRealizadas = new System.Windows.Forms.Label();
            lblFechaVencimiento = new System.Windows.Forms.Label();
            lblFormaPago = new System.Windows.Forms.Label();
            lblMonto = new System.Windows.Forms.Label();
            lblCuotas = new System.Windows.Forms.Label();
            btnImprimir = new System.Windows.Forms.Button();
            lblClub = new System.Windows.Forms.Label();
            btnVolver = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lblFechaActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFechaActual.Location = new System.Drawing.Point(20, 102);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new System.Drawing.Size(138, 28);
            lblFechaActual.TabIndex = 0;
            lblFechaActual.Text = "Fecha Actual:";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreCliente.Location = new System.Drawing.Point(20, 151);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new System.Drawing.Size(166, 28);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // lblActividadesRealizadas
            // 
            lblActividadesRealizadas.AutoSize = true;
            lblActividadesRealizadas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lblActividadesRealizadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblActividadesRealizadas.Location = new System.Drawing.Point(20, 198);
            lblActividadesRealizadas.Name = "lblActividadesRealizadas";
            lblActividadesRealizadas.Size = new System.Drawing.Size(233, 28);
            lblActividadesRealizadas.TabIndex = 2;
            lblActividadesRealizadas.Text = "Actividades Realizadas:";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lblFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFechaVencimiento.Location = new System.Drawing.Point(20, 250);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new System.Drawing.Size(224, 28);
            lblFechaVencimiento.TabIndex = 3;
            lblFechaVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lblFormaPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFormaPago.Location = new System.Drawing.Point(20, 304);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new System.Drawing.Size(129, 28);
            lblFormaPago.TabIndex = 4;
            lblFormaPago.Text = "Forma Pago:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lblMonto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMonto.Location = new System.Drawing.Point(20, 360);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new System.Drawing.Size(93, 31);
            lblMonto.TabIndex = 5;
            lblMonto.Text = "Monto:";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            lblCuotas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCuotas.Location = new System.Drawing.Point(442, 360);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new System.Drawing.Size(93, 31);
            lblCuotas.TabIndex = 6;
            lblCuotas.Text = "Cuotas:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnImprimir.Location = new System.Drawing.Point(325, 473);
            btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(109, 47);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.BackColor = System.Drawing.Color.LightCoral;
            lblClub.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblClub.Location = new System.Drawing.Point(275, 20);
            lblClub.Name = "lblClub";
            lblClub.Size = new System.Drawing.Size(249, 38);
            lblClub.TabIndex = 8;
            lblClub.Text = "CLUB DEPORTIVO";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnVolver.Location = new System.Drawing.Point(117, 473);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(110, 47);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(823, 560);
            Controls.Add(btnVolver);
            Controls.Add(lblClub);
            Controls.Add(btnImprimir);
            Controls.Add(lblCuotas);
            Controls.Add(lblMonto);
            Controls.Add(lblFormaPago);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(lblActividadesRealizadas);
            Controls.Add(lblNombreCliente);
            Controls.Add(lblFechaActual);
            Name = "FrmFactura";
            Text = "Factura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblActividadesRealizadas;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Button btnVolver;
    }
}






/*namespace SistemaClubDeportivo2
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
        /// 
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblActividadesRealizadas;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnImprimir;

        private void InitializeComponent()
        {
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblActividadesRealizadas = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(20, 20);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(87, 20);
            this.lblFechaActual.TabIndex = 0;
            this.lblFechaActual.Text = "Fecha Actual:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 50);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(106, 20);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // lblActividadesRealizadas
            // 
            this.lblActividadesRealizadas.AutoSize = true;
            this.lblActividadesRealizadas.Location = new System.Drawing.Point(20, 80);
            this.lblActividadesRealizadas.Name = "lblActividadesRealizadas";
            this.lblActividadesRealizadas.Size = new System.Drawing.Size(158, 20);
            this.lblActividadesRealizadas.TabIndex = 2;
            this.lblActividadesRealizadas.Text = "Actividades Realizadas:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(20, 110);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(136, 20);
            this.lblFechaVencimiento.TabIndex = 3;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(20, 140);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(81, 20);
            this.lblFormaPago.TabIndex = 4;
            this.lblFormaPago.Text = "Forma Pago:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(20, 170);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(52, 20);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new System.Drawing.Point(342, 541);
            btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(86, 31);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblActividadesRealizadas);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblFechaActual);
            this.Name = "FrmFactura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}*/
/*private void InitializeComponent()
{
    pnlComprobante = new System.Windows.Forms.Panel();
    lblClubD = new System.Windows.Forms.Label();
    panel1 = new System.Windows.Forms.Panel();
    lblDfecha = new System.Windows.Forms.Label();
    pnlDatos = new System.Windows.Forms.Panel();
    lblValor = new System.Windows.Forms.Label();
    lblFPago = new System.Windows.Forms.Label();
    lblDia = new System.Windows.Forms.Label();
    lblActividad = new System.Windows.Forms.Label();
    lblCliente = new System.Windows.Forms.Label();
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
    pnlComprobante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    pnlComprobante.Name = "pnlComprobante";
    pnlComprobante.Size = new System.Drawing.Size(913, 81);
    pnlComprobante.TabIndex = 0;
    //pnlComprobante.Paint += pnlComprobante_Paint;
    // 
    // lblClubD
    // 
    lblClubD.AutoSize = true;
    lblClubD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
    lblClubD.Location = new System.Drawing.Point(14, 40);
    lblClubD.Name = "lblClubD";
    lblClubD.Size = new System.Drawing.Size(126, 20);
    lblClubD.TabIndex = 0;
    lblClubD.Text = "CLUB DEPORTIVO";
    // 
    // panel1
    // 
    panel1.Controls.Add(lblDfecha);
    panel1.Controls.Add(lblClubD);
    panel1.Location = new System.Drawing.Point(0, 89);
    panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    panel1.Name = "panel1";
    panel1.Size = new System.Drawing.Size(913, 133);
    panel1.TabIndex = 1;
    // 
    // lblDfecha
    // 
    lblDfecha.AutoSize = true;
    lblDfecha.Location = new System.Drawing.Point(537, 16);
    lblDfecha.Name = "lblDfecha";
    lblDfecha.Size = new System.Drawing.Size(47, 20);
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
    pnlDatos.Location = new System.Drawing.Point(0, 247);
    pnlDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    pnlDatos.Name = "pnlDatos";
    pnlDatos.Size = new System.Drawing.Size(913, 259);
    pnlDatos.TabIndex = 2;
    // 
    // lblValor
    // 
    lblValor.AutoSize = true;
    lblValor.Location = new System.Drawing.Point(384, 165);
    lblValor.Name = "lblValor";
    lblValor.Size = new System.Drawing.Size(53, 20);
    lblValor.TabIndex = 4;
    lblValor.Text = "Monto";
    // 
    // lblFPago
    // 
    lblFPago.AutoSize = true;
    lblFPago.Location = new System.Drawing.Point(33, 165);
    lblFPago.Name = "lblFPago";
    lblFPago.Size = new System.Drawing.Size(111, 20);
    lblFPago.TabIndex = 3;
    lblFPago.Text = "Forma de pago";
    // 
    // lblDia
    // 
    lblDia.AutoSize = true;
    lblDia.Location = new System.Drawing.Point(26, 125);
    lblDia.Name = "lblDia";
    lblDia.Size = new System.Drawing.Size(47, 20);
    lblDia.TabIndex = 2;
    lblDia.Text = "Fecha";
    // 
    // lblActividad
    // 
    lblActividad.AutoSize = true;
    lblActividad.Location = new System.Drawing.Point(26, 77);
    lblActividad.Name = "lblActividad";
    lblActividad.Size = new System.Drawing.Size(99, 20);
    lblActividad.TabIndex = 1;
    lblActividad.Text = "Se inscribe a :";
    // 
    // lblCliente
    // 
    lblCliente.AutoSize = true;
    lblCliente.Location = new System.Drawing.Point(26, 29);
    lblCliente.Name = "lblCliente";
    lblCliente.Size = new System.Drawing.Size(55, 20);
    lblCliente.TabIndex = 0;
    lblCliente.Text = "NombreCliente";
    // 
    // btnImprimir
    // 
    btnImprimir.Location = new System.Drawing.Point(342, 541);
    btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    btnImprimir.Name = "btnImprimir";
    btnImprimir.Size = new System.Drawing.Size(86, 31);
    btnImprimir.TabIndex = 3;
    btnImprimir.Text = "Imprimir";
    btnImprimir.UseVisualStyleBackColor = true;
    // 
    // FrmFactura
    // 
    AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    ClientSize = new System.Drawing.Size(914, 600);
    Controls.Add(btnImprimir);
    Controls.Add(pnlDatos);
    Controls.Add(panel1);
    Controls.Add(pnlComprobante);
    Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
    Name = "FrmFactura";
    Text = "FrmFactura";
    panel1.ResumeLayout(false);
    panel1.PerformLayout();
    pnlDatos.ResumeLayout(false);
    pnlDatos.PerformLayout();
    ResumeLayout(false);
}*/

//#endregion

/*private System.Windows.Forms.Label lblClubD;
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
}*/