namespace SistemaClubDeportivo2
{
    partial class FrmPagar
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
            txtNcliente = new System.Windows.Forms.TextBox();
            lblNCliente = new System.Windows.Forms.Label();
            lblNcli = new System.Windows.Forms.Label();
            grpFormaPago = new System.Windows.Forms.GroupBox();
            rbTarjeta = new System.Windows.Forms.RadioButton();
            optEfvo = new System.Windows.Forms.RadioButton();
            btnPagar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            btnComprobante = new System.Windows.Forms.Button();
            grpFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // txtNcliente
            // 
            txtNcliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            txtNcliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtNcliente.Location = new System.Drawing.Point(85, 62);
            txtNcliente.Name = "txtNcliente";
            txtNcliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            txtNcliente.Size = new System.Drawing.Size(124, 29);
            txtNcliente.TabIndex = 0;
            // 
            // lblNCliente
            // 
            lblNCliente.AutoSize = true;
            lblNCliente.BackColor = System.Drawing.Color.Teal;
            lblNCliente.Location = new System.Drawing.Point(114, 76);
            lblNCliente.Name = "lblNCliente";
            lblNCliente.Size = new System.Drawing.Size(0, 15);
            lblNCliente.TabIndex = 1;
            // 
            // lblNcli
            // 
            lblNcli.AutoSize = true;
            lblNcli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNcli.Location = new System.Drawing.Point(61, 23);
            lblNcli.Name = "lblNcli";
            lblNcli.Size = new System.Drawing.Size(196, 21);
            lblNcli.TabIndex = 2;
            lblNcli.Text = "Ingrese Número de Cliente";
            // 
            // grpFormaPago
            // 
            grpFormaPago.Controls.Add(rbTarjeta);
            grpFormaPago.Controls.Add(optEfvo);
            grpFormaPago.Location = new System.Drawing.Point(453, 23);
            grpFormaPago.Name = "grpFormaPago";
            grpFormaPago.Size = new System.Drawing.Size(177, 100);
            grpFormaPago.TabIndex = 3;
            grpFormaPago.TabStop = false;
            grpFormaPago.Text = "Forma de Pago";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new System.Drawing.Point(3, 44);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new System.Drawing.Size(59, 19);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new System.Drawing.Point(3, 19);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new System.Drawing.Size(67, 19);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Location = new System.Drawing.Point(114, 129);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(75, 23);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new System.Drawing.Point(493, 213);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new System.Drawing.Point(114, 245);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new System.Drawing.Size(75, 23);
            btnComprobante.TabIndex = 6;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            // 
            // FrmPagar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnComprobante);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(grpFormaPago);
            Controls.Add(lblNcli);
            Controls.Add(lblNCliente);
            Controls.Add(txtNcliente);
            Name = "FrmPagar";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            Text = "FrmPagar";
            grpFormaPago.ResumeLayout(false);
            grpFormaPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNcliente;
        private System.Windows.Forms.Label lblNCliente;
        private System.Windows.Forms.Label lblNcli;
        private System.Windows.Forms.GroupBox grpFormaPago;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton optEfvo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnComprobante;
    }
}