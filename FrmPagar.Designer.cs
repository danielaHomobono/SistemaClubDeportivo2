﻿using System.Windows.Forms;

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
            btnPagar = new Button();
            btnVolver = new Button();
            btnComprobante = new Button();
            lblNombreCliente = new Label();
            lblMontoTotal = new Label();
            btnBuscar = new Button();
            lblFechaVencimiento = new Label();
            lblTipoPago = new Label();
            optCuotaMensual = new RadioButton();
            optCuotaDiaria = new RadioButton();
            lblMontoDiario = new Label();
            grpFormaPago.SuspendLayout();
            grpCuotas.SuspendLayout();
            SuspendLayout();
            // 
            // txtDNI
            // 
            txtDNI.Location = new System.Drawing.Point(331, 43);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(232, 27);
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
            lblNcli.BackColor = System.Drawing.SystemColors.ControlLight;
            lblNcli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNcli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lblNcli.Location = new System.Drawing.Point(70, 39);
            lblNcli.Name = "lblNcli";
            lblNcli.Size = new System.Drawing.Size(221, 28);
            lblNcli.TabIndex = 2;
            lblNcli.Text = " Número Dni del Cliente";
            // 
            // grpFormaPago
            // 
            grpFormaPago.Controls.Add(optEfvo);
            grpFormaPago.Controls.Add(optTarjeta);
            grpFormaPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grpFormaPago.Location = new System.Drawing.Point(98, 364);
            grpFormaPago.Name = "grpFormaPago";
            grpFormaPago.Size = new System.Drawing.Size(200, 118);
            grpFormaPago.TabIndex = 3;
            grpFormaPago.TabStop = false;
            grpFormaPago.Text = "Forma de Pago";
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new System.Drawing.Point(16, 33);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new System.Drawing.Size(110, 32);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new System.Drawing.Point(16, 58);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new System.Drawing.Size(98, 32);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // grpCuotas
            // 
            grpCuotas.Controls.Add(opt3Cuotas);
            grpCuotas.Controls.Add(opt6Cuotas);
            grpCuotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            grpCuotas.Location = new System.Drawing.Point(392, 362);
            grpCuotas.Name = "grpCuotas";
            grpCuotas.Size = new System.Drawing.Size(218, 120);
            grpCuotas.TabIndex = 4;
            grpCuotas.TabStop = false;
            grpCuotas.Text = "Número de Cuotas";
            // 
            // opt3Cuotas
            // 
            opt3Cuotas.AutoSize = true;
            opt3Cuotas.Location = new System.Drawing.Point(10, 33);
            opt3Cuotas.Name = "opt3Cuotas";
            opt3Cuotas.Size = new System.Drawing.Size(115, 32);
            opt3Cuotas.TabIndex = 0;
            opt3Cuotas.TabStop = true;
            opt3Cuotas.Text = "3 Cuotas";
            opt3Cuotas.UseVisualStyleBackColor = true;
            // 
            // opt6Cuotas
            // 
            opt6Cuotas.AutoSize = true;
            opt6Cuotas.Location = new System.Drawing.Point(10, 58);
            opt6Cuotas.Name = "opt6Cuotas";
            opt6Cuotas.Size = new System.Drawing.Size(115, 32);
            opt6Cuotas.TabIndex = 1;
            opt6Cuotas.TabStop = true;
            opt6Cuotas.Text = "6 Cuotas";
            opt6Cuotas.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnPagar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPagar.Location = new System.Drawing.Point(98, 530);
            btnPagar.Margin = new Padding(3, 4, 3, 4);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(114, 39);
            btnPagar.TabIndex = 6;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnVolver.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnVolver.Location = new System.Drawing.Point(744, 530);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(86, 39);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnComprobante.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnComprobante.Location = new System.Drawing.Point(374, 530);
            btnComprobante.Margin = new Padding(3, 4, 3, 4);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new System.Drawing.Size(175, 39);
            btnComprobante.TabIndex = 8;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new System.Drawing.Point(80, 89);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new System.Drawing.Size(146, 20);
            lblNombreCliente.TabIndex = 9;
            lblNombreCliente.Text = "Nombre del Cliente: ";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new System.Drawing.Point(80, 126);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new System.Drawing.Size(156, 20);
            lblMontoTotal.TabIndex = 10;
            lblMontoTotal.Text = "Monto Total  a pagar: ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscar.Location = new System.Drawing.Point(640, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(144, 44);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new System.Drawing.Point(80, 202);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new System.Drawing.Size(178, 20);
            lblFechaVencimiento.TabIndex = 12;
            lblFechaVencimiento.Text = "lblFecha de Vencimiento: ";
            // 
            // lblTipoPago
            // 
            lblTipoPago.AutoSize = true;
            lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTipoPago.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblTipoPago.Location = new System.Drawing.Point(80, 243);
            lblTipoPago.Name = "lblTipoPago";
            lblTipoPago.Size = new System.Drawing.Size(147, 28);
            lblTipoPago.TabIndex = 13;
            lblTipoPago.Text = "Tipo de Pago: ";
            // 
            // optCuotaMensual
            // 
            optCuotaMensual.AutoSize = true;
            optCuotaMensual.BackColor = System.Drawing.SystemColors.HotTrack;
            optCuotaMensual.Location = new System.Drawing.Point(70, 296);
            optCuotaMensual.Name = "optCuotaMensual";
            optCuotaMensual.Size = new System.Drawing.Size(128, 24);
            optCuotaMensual.TabIndex = 14;
            optCuotaMensual.TabStop = true;
            optCuotaMensual.Text = "Cuota Mensual";
            optCuotaMensual.UseVisualStyleBackColor = false;
            // 
            // optCuotaDiaria
            // 
            optCuotaDiaria.AutoSize = true;
            optCuotaDiaria.BackColor = System.Drawing.SystemColors.HotTrack;
            optCuotaDiaria.Location = new System.Drawing.Point(331, 296);
            optCuotaDiaria.Name = "optCuotaDiaria";
            optCuotaDiaria.Size = new System.Drawing.Size(113, 24);
            optCuotaDiaria.TabIndex = 15;
            optCuotaDiaria.TabStop = true;
            optCuotaDiaria.Text = "Cuota Diaria";
            optCuotaDiaria.UseVisualStyleBackColor = false;
            // 
            // lblMontoDiario
            // 
            lblMontoDiario.AutoSize = true;
            lblMontoDiario.Location = new System.Drawing.Point(80, 164);
            lblMontoDiario.Name = "lblMontoDiario";
            lblMontoDiario.Size = new System.Drawing.Size(105, 20);
            lblMontoDiario.TabIndex = 16;
            lblMontoDiario.Text = "Monto Diario: ";
            // 
            // FrmPagar
            // 
            ClientSize = new System.Drawing.Size(1032, 616);
            Controls.Add(lblMontoDiario);
            Controls.Add(optCuotaDiaria);
            Controls.Add(optCuotaMensual);
            Controls.Add(lblTipoPago);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(btnBuscar);
            Controls.Add(lblMontoTotal);
            Controls.Add(lblNombreCliente);
            Controls.Add(txtDNI);
            Controls.Add(lblNCliente);
            Controls.Add(lblNcli);
            Controls.Add(grpFormaPago);
            Controls.Add(grpCuotas);
            Controls.Add(btnPagar);
            Controls.Add(btnVolver);
            Controls.Add(btnComprobante);
            Name = "FrmPagar";
            Text = "FrmPagar";
            grpFormaPago.ResumeLayout(false);
            grpFormaPago.PerformLayout();
            grpCuotas.ResumeLayout(false);
            grpCuotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNombreCliente;
        private Label lblMontoTotal;
        private Button btnBuscar;
        private Label lblFechaVencimiento;
        private Label lblTipoPago;
        private RadioButton optCuotaMensual;
        private RadioButton optCuotaDiaria;
        private Label lblMontoDiario;
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

