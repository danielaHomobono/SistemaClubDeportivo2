using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    partial class FrmPagar : Form
    {
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNCliente;
        private System.Windows.Forms.Label lblNcli;
        private System.Windows.Forms.GroupBox grpFormaPago;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton optEfvo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnComprobante;

        public FrmPagar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNCliente = new System.Windows.Forms.Label();
            this.lblNcli = new System.Windows.Forms.Label();
            this.grpFormaPago = new System.Windows.Forms.GroupBox();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.optEfvo = new System.Windows.Forms.RadioButton();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.grpFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(97, 83);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(141, 22);
            this.txtDNI.TabIndex = 0;
            // 
            // lblNCliente
            // 
            this.lblNCliente.AutoSize = true;
            this.lblNCliente.Location = new System.Drawing.Point(130, 101);
            this.lblNCliente.Name = "lblNCliente";
            this.lblNCliente.Size = new System.Drawing.Size(0, 17);
            this.lblNCliente.TabIndex = 1;
            // 
            // lblNcli
            // 
            this.lblNcli.AutoSize = true;
            this.lblNcli.Location = new System.Drawing.Point(70, 31);
            this.lblNcli.Name = "lblNcli";
            this.lblNcli.Size = new System.Drawing.Size(284, 17);
            this.lblNcli.TabIndex = 2;
            this.lblNcli.Text = "Ingrese Número Dni del Cliente";
            // 
            // grpFormaPago
            // 
            this.grpFormaPago.Controls.Add(this.rbTarjeta);
            this.grpFormaPago.Controls.Add(this.optEfvo);
            this.grpFormaPago.Location = new System.Drawing.Point(518, 31);
            this.grpFormaPago.Name = "grpFormaPago";
            this.grpFormaPago.Size = new System.Drawing.Size(202, 133);
            this.grpFormaPago.TabIndex = 3;
            this.grpFormaPago.TabStop = false;
            this.grpFormaPago.Text = "Forma de Pago";
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(6, 59);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(74, 21);
            this.rbTarjeta.TabIndex = 1;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            this.optEfvo.AutoSize = true;
            this.optEfvo.Location = new System.Drawing.Point(6, 25);
            this.optEfvo.Name = "optEfvo";
            this.optEfvo.Size = new System.Drawing.Size(83, 21);
            this.optEfvo.TabIndex = 0;
            this.optEfvo.TabStop = true;
            this.optEfvo.Text = "Efectivo";
            this.optEfvo.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(130, 172);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(86, 31);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(563, 284);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 31);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnComprobante
            // 
            this.btnComprobante.Location = new System.Drawing.Point(130, 327);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(86, 31);
            this.btnComprobante.TabIndex = 6;
            this.btnComprobante.Text = "Comprobante";
            this.btnComprobante.UseVisualStyleBackColor = true;
            // 
            // FrmPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnComprobante);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.grpFormaPago);
            this.Controls.Add(this.lblNcli);
            this.Controls.Add(this.lblNCliente);
            this.Controls.Add(this.txtDNI);
            this.Name = "FrmPagar";
            this.Text = "FrmPagar";
            this.grpFormaPago.ResumeLayout(false);
            this.grpFormaPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
