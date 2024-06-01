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
            txtDNI = new TextBox();
            lblNCliente = new Label();
            lblNcli = new Label();
            grpFormaPago = new GroupBox();
            rbTarjeta = new RadioButton();
            optEfvo = new RadioButton();
            btnPagar = new Button();
            btnVolver = new Button();
            btnComprobante = new Button();
            grpFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // txtDNI
            // 
            txtDNI.Location = new System.Drawing.Point(97, 104);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(141, 27);
            txtDNI.TabIndex = 0;
            // 
            // lblNCliente
            // 
            lblNCliente.AutoSize = true;
            lblNCliente.Location = new System.Drawing.Point(130, 126);
            lblNCliente.Name = "lblNCliente";
            lblNCliente.Size = new System.Drawing.Size(0, 20);
            lblNCliente.TabIndex = 1;
            // 
            // lblNcli
            // 
            lblNcli.AutoSize = true;
            lblNcli.Location = new System.Drawing.Point(70, 39);
            lblNcli.Name = "lblNcli";
            lblNcli.Size = new System.Drawing.Size(217, 20);
            lblNcli.TabIndex = 2;
            lblNcli.Text = "Ingrese Número Dni del Cliente";
            // 
            // grpFormaPago
            // 
            grpFormaPago.Controls.Add(rbTarjeta);
            grpFormaPago.Controls.Add(optEfvo);
            grpFormaPago.Location = new System.Drawing.Point(518, 39);
            grpFormaPago.Margin = new Padding(3, 4, 3, 4);
            grpFormaPago.Name = "grpFormaPago";
            grpFormaPago.Padding = new Padding(3, 4, 3, 4);
            grpFormaPago.Size = new System.Drawing.Size(202, 166);
            grpFormaPago.TabIndex = 3;
            grpFormaPago.TabStop = false;
            grpFormaPago.Text = "Forma de Pago";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new System.Drawing.Point(6, 74);
            rbTarjeta.Margin = new Padding(3, 4, 3, 4);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new System.Drawing.Size(74, 24);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new System.Drawing.Point(6, 31);
            optEfvo.Margin = new Padding(3, 4, 3, 4);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new System.Drawing.Size(83, 24);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Location = new System.Drawing.Point(130, 215);
            btnPagar.Margin = new Padding(3, 4, 3, 4);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(86, 39);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new System.Drawing.Point(563, 355);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(86, 39);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new System.Drawing.Point(130, 409);
            btnComprobante.Margin = new Padding(3, 4, 3, 4);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new System.Drawing.Size(86, 39);
            btnComprobante.TabIndex = 6;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // FrmPagar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 750);
            Controls.Add(btnComprobante);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(grpFormaPago);
            Controls.Add(lblNcli);
            Controls.Add(lblNCliente);
            Controls.Add(txtDNI);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPagar";
            Text = "FrmPagar";
            grpFormaPago.ResumeLayout(false);
            grpFormaPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
