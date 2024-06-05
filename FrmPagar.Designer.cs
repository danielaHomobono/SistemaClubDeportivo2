using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    partial class FrmPagar : Form
    {
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNCliente;
        private System.Windows.Forms.Label lblNcli;
        private System.Windows.Forms.GroupBox grpFormaPago;
        private System.Windows.Forms.RadioButton optEfvo;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.GroupBox grpCuotas;
        private System.Windows.Forms.RadioButton opt3Cuotas;
        private System.Windows.Forms.RadioButton opt6Cuotas;
        private System.Windows.Forms.GroupBox grpTipoPago;
        private System.Windows.Forms.RadioButton optCuota;
        private System.Windows.Forms.RadioButton optActividad;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnComprobante;

        private void InitializeComponent()
        {
            txtDNI = new TextBox();
            lblNCliente = new Label();
            lblNcli = new Label();
            grpFormaPago = new GroupBox();
            optEfvo = new RadioButton();
            optTarjeta = new RadioButton();
            grpCuotas = new GroupBox();
            opt3Cuotas = new RadioButton();
            opt6Cuotas = new RadioButton();
            grpTipoPago = new GroupBox();
            optCuota = new RadioButton();
            optActividad = new RadioButton();
            btnPagar = new Button();
            btnVolver = new Button();
            btnComprobante = new Button();
            grpFormaPago.SuspendLayout();
            grpCuotas.SuspendLayout();
            grpTipoPago.SuspendLayout();
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
            grpFormaPago.Controls.Add(optEfvo);
            grpFormaPago.Controls.Add(optTarjeta);
            grpFormaPago.Location = new System.Drawing.Point(20, 150);
            grpFormaPago.Name = "grpFormaPago";
            grpFormaPago.Size = new System.Drawing.Size(200, 100);
            grpFormaPago.TabIndex = 3;
            grpFormaPago.TabStop = false;
            grpFormaPago.Text = "Forma de Pago";
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new System.Drawing.Point(10, 20);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new System.Drawing.Size(83, 24);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new System.Drawing.Point(10, 40);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new System.Drawing.Size(74, 24);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // grpCuotas
            // 
            grpCuotas.Controls.Add(opt3Cuotas);
            grpCuotas.Controls.Add(opt6Cuotas);
            grpCuotas.Location = new System.Drawing.Point(230, 150);
            grpCuotas.Name = "grpCuotas";
            grpCuotas.Size = new System.Drawing.Size(200, 100);
            grpCuotas.TabIndex = 4;
            grpCuotas.TabStop = false;
            grpCuotas.Text = "Número de Cuotas";
            // 
            // opt3Cuotas
            // 
            opt3Cuotas.AutoSize = true;
            opt3Cuotas.Location = new System.Drawing.Point(10, 20);
            opt3Cuotas.Name = "opt3Cuotas";
            opt3Cuotas.Size = new System.Drawing.Size(87, 24);
            opt3Cuotas.TabIndex = 0;
            opt3Cuotas.TabStop = true;
            opt3Cuotas.Text = "3 Cuotas";
            opt3Cuotas.UseVisualStyleBackColor = true;
            // 
            // opt6Cuotas
            // 
            opt6Cuotas.AutoSize = true;
            opt6Cuotas.Location = new System.Drawing.Point(10, 40);
            opt6Cuotas.Name = "opt6Cuotas";
            opt6Cuotas.Size = new System.Drawing.Size(87, 24);
            opt6Cuotas.TabIndex = 1;
            opt6Cuotas.TabStop = true;
            opt6Cuotas.Text = "6 Cuotas";
            opt6Cuotas.UseVisualStyleBackColor = true;
            // 
            // grpTipoPago
            // 
            grpTipoPago.Controls.Add(optCuota);
            grpTipoPago.Controls.Add(optActividad);
            grpTipoPago.Location = new System.Drawing.Point(450, 150);
            grpTipoPago.Name = "grpTipoPago";
            grpTipoPago.Size = new System.Drawing.Size(200, 100);
            grpTipoPago.TabIndex = 5;
            grpTipoPago.TabStop = false;
            grpTipoPago.Text = "Tipo de Pago";
            // 
            // optCuota
            // 
            optCuota.AutoSize = true;
            optCuota.Location = new System.Drawing.Point(10, 20);
            optCuota.Name = "optCuota";
            optCuota.Size = new System.Drawing.Size(69, 24);
            optCuota.TabIndex = 0;
            optCuota.TabStop = true;
            optCuota.Text = "Cuota";
            optCuota.UseVisualStyleBackColor = true;
            // 
            // optActividad
            // 
            optActividad.AutoSize = true;
            optActividad.Location = new System.Drawing.Point(10, 40);
            optActividad.Name = "optActividad";
            optActividad.Size = new System.Drawing.Size(93, 24);
            optActividad.TabIndex = 1;
            optActividad.TabStop = true;
            optActividad.Text = "Actividad";
            optActividad.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.Location = new System.Drawing.Point(163, 322);
            btnPagar.Margin = new Padding(3, 4, 3, 4);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(86, 39);
            btnPagar.TabIndex = 6;
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
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new System.Drawing.Point(139, 411);
            btnComprobante.Margin = new Padding(3, 4, 3, 4);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new System.Drawing.Size(119, 39);
            btnComprobante.TabIndex = 8;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // FrmPagar
            // 
            ClientSize = new System.Drawing.Size(875, 543);
            Controls.Add(txtDNI);
            Controls.Add(lblNCliente);
            Controls.Add(lblNcli);
            Controls.Add(grpFormaPago);
            Controls.Add(grpCuotas);
            Controls.Add(grpTipoPago);
            Controls.Add(btnPagar);
            Controls.Add(btnVolver);
            Controls.Add(btnComprobante);
            Name = "FrmPagar";
            Text = "FrmPagar";
            grpFormaPago.ResumeLayout(false);
            grpFormaPago.PerformLayout();
            grpCuotas.ResumeLayout(false);
            grpCuotas.PerformLayout();
            grpTipoPago.ResumeLayout(false);
            grpTipoPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}



/*namespace SistemaClubDeportivo2
{
    partial class FrmPagar : Form

        

    {
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNCliente;
        private System.Windows.Forms.Label lblNcli;
        private System.Windows.Forms.GroupBox grpFormaPago;
        private System.Windows.Forms.RadioButton optEfvo;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.GroupBox grpCuotas;
        private System.Windows.Forms.RadioButton opt3Cuotas;
        private System.Windows.Forms.RadioButton opt6Cuotas;
        private System.Windows.Forms.GroupBox grpTipoPago;
        private System.Windows.Forms.RadioButton optCuota;
        private System.Windows.Forms.RadioButton optActividad;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnComprobante;

    private void InitializeComponent()
        {
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNCliente = new System.Windows.Forms.Label();
            this.lblNcli = new System.Windows.Forms.Label();
            this.grpFormaPago = new System.Windows.Forms.GroupBox();
            this.optEfvo = new System.Windows.Forms.RadioButton();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.grpCuotas = new System.Windows.Forms.GroupBox();
            this.opt3Cuotas = new System.Windows.Forms.RadioButton();
            this.opt6Cuotas = new System.Windows.Forms.RadioButton();
            this.grpTipoPago = new System.Windows.Forms.GroupBox();
            this.optCuota = new System.Windows.Forms.RadioButton();
            this.optActividad = new System.Windows.Forms.RadioButton();
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
            this.grpFormaPago.Controls.Add(this.optEfvo);
            this.grpFormaPago.Controls.Add(this.optTarjeta);
            this.grpFormaPago.Location = new System.Drawing.Point(20, 150);
            this.grpFormaPago.Name = "grpFormaPago";
            this.grpFormaPago.Size = new System.Drawing.Size(200, 100);
            this.grpFormaPago.TabIndex = 0;
            this.grpFormaPago.TabStop = false;
            this.grpFormaPago.Text = "Forma de Pago";
            // 
            // optEfvo
            // 
            this.optEfvo.AutoSize = true;
            this.optEfvo.Location = new System.Drawing.Point(10, 20);
            this.optEfvo.Name = "optEfvo";
            this.optEfvo.Size = new System.Drawing.Size(64, 17);
            this.optEfvo.TabIndex = 0;
            this.optEfvo.TabStop = true;
            this.optEfvo.Text = "Efectivo";
            this.optEfvo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(10, 40);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            // 
            // grpCuotas
            // 
            this.grpCuotas.Controls.Add(this.opt3Cuotas);
            this.grpCuotas.Controls.Add(this.opt6Cuotas);
            this.grpCuotas.Location = new System.Drawing.Point(230, 150);
            this.grpCuotas.Name = "grpCuotas";
            this.grpCuotas.Size = new System.Drawing.Size(200, 100);
            this.grpCuotas.TabIndex = 1;
            this.grpCuotas.TabStop = false;
            this.grpCuotas.Text = "Número de Cuotas";
            // 
            // opt3Cuotas
            // 
            this.opt3Cuotas.AutoSize = true;
            this.opt3Cuotas.Location = new System.Drawing.Point(10, 20);
            this.opt3Cuotas.Name = "opt3Cuotas";
            this.opt3Cuotas.Size = new System.Drawing.Size(62, 17);
            this.opt3Cuotas.TabIndex = 0;
            this.opt3Cuotas.TabStop = true;
            this.opt3Cuotas.Text = "3 Cuotas";
            this.opt3Cuotas.UseVisualStyleBackColor = true;
            // 
            // opt6Cuotas
            // 
            this.opt6Cuotas.AutoSize = true;
            this.opt6Cuotas.Location = new System.Drawing.Point(10, 40);
            this.opt6Cuotas.Name = "opt6Cuotas";
            this.opt6Cuotas.Size = new System.Drawing.Size(62, 17);
            this.opt6Cuotas.TabIndex = 1;
            this.opt6Cuotas.TabStop = true;
            this.opt6Cuotas.Text = "6 Cuotas";
            this.opt6Cuotas.UseVisualStyleBackColor = true;
            // 
            // grpTipoPago
            // 
            this.grpTipoPago.Controls.Add(this.optCuota);
            this.grpTipoPago.Controls.Add(this.optActividad);
            this.grpTipoPago.Location = new System.Drawing.Point(450, 150);
            this.grpTipoPago.Name = "grpTipoPago";
            this.grpTipoPago.Size = new System.Drawing.Size(200, 100);
            this.grpTipoPago.TabIndex = 2;
            this.grpTipoPago.TabStop = false;
            this.grpTipoPago.Text = "Tipo de Pago";
            // 
            // optCuota
            // 
            this.optCuota.AutoSize = true;
            this.optCuota.Location = new System.Drawing.Point(10, 20);
            this.optCuota.Name = "optCuota";
            this.optCuota.Size = new System.Drawing.Size(53, 17);
            this.optCuota.TabIndex = 0;
            this.optCuota.TabStop = true;
            this.optCuota.Text = "Cuota";
            this.optCuota.UseVisualStyleBackColor = true;
            // 
            // optActividad
            // 
            this.optActividad.AutoSize = true;
            this.optActividad.Location = new System.Drawing.Point(10, 40);
            this.optActividad.Name = "optActividad";
            this.optActividad.Size = new System.Drawing.Size(68, 17);
            this.optActividad.TabIndex = 1;
            this.optActividad.TabStop = true;
            this.optActividad.Text = "Actividad";
            this.optActividad.UseVisualStyleBackColor = true;
            //
            //
            // FrmPagar
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpFormaPago);
            this.Controls.Add(this.grpCuotas);
            this.Controls.Add(this.grpTipoPago);
            this.Name = "FrmPagar";
            this.Text = "FrmPagar";
            this.grpFormaPago.ResumeLayout(false);
            this.grpFormaPago.PerformLayout();
            this.grpCuotas.ResumeLayout(false);
            this.grpCuotas.PerformLayout();
            this.grpTipoPago.ResumeLayout(false);
            this.grpTipoPago.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}*/
/*private System.Windows.Forms.TextBox txtDNI;
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
    btnComprobante.Location = new System.Drawing.Point(139, 411);
    btnComprobante.Margin = new Padding(3, 4, 3, 4);
    btnComprobante.Name = "btnComprobante";
    btnComprobante.Size = new System.Drawing.Size(119, 39);
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
}*/

