using System;
using System.Windows.Forms;

namespace SistemaClubDeportivo2
{
    partial class InscribirActividad
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            dtgvDatos = new DataGridView();
            Nombre_Actividad = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Nombre_Profesor = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            idSesion = new DataGridViewTextBoxColumn();
            btnInscribir = new Button();
            btnSalir = new Button();
            txtDNI = new TextBox();
            lblClienteNombre = new Label();
            btnBuscar = new Button();
            lblIngresoDNI = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(229, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(416, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inscripción a Actividades";
            // 
            // dtgvDatos
            // 
            dtgvDatos.AllowUserToDeleteRows = false;
            dtgvDatos.AllowUserToOrderColumns = true;
            dtgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new DataGridViewColumn[] { Nombre_Actividad, Fecha, Nombre_Profesor, Precio, idSesion });
            dtgvDatos.Location = new System.Drawing.Point(42, 178);
            dtgvDatos.Margin = new Padding(3, 4, 3, 4);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.RowHeadersWidth = 51;
            dtgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDatos.Size = new System.Drawing.Size(549, 328);
            dtgvDatos.TabIndex = 1;
            // 
            // Nombre_Actividad
            // 
            Nombre_Actividad.HeaderText = "Nombre Actividad";
            Nombre_Actividad.MinimumWidth = 6;
            Nombre_Actividad.Name = "Nombre_Actividad";
            Nombre_Actividad.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Nombre_Profesor
            // 
            Nombre_Profesor.HeaderText = "Nombre Profesor";
            Nombre_Profesor.MinimumWidth = 6;
            Nombre_Profesor.Name = "Nombre_Profesor";
            Nombre_Profesor.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // idSesion
            // 
            idSesion.HeaderText = "ID Sesión";
            idSesion.MinimumWidth = 6;
            idSesion.Name = "idSesion";
            idSesion.Visible = false;
            idSesion.Width = 125;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new System.Drawing.Point(261, 528);
            btnInscribir.Margin = new Padding(3, 4, 3, 4);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new System.Drawing.Size(114, 40);
            btnInscribir.TabIndex = 2;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(593, 528);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(114, 40);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new System.Drawing.Point(69, 89);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(125, 27);
            txtDNI.TabIndex = 4;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Location = new System.Drawing.Point(125, 119);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new System.Drawing.Size(13, 20);
            lblClienteNombre.TabIndex = 5;
            lblClienteNombre.Text = "l";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(109, 142);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(94, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblIngresoDNI
            // 
            lblIngresoDNI.AutoSize = true;
            lblIngresoDNI.Location = new System.Drawing.Point(125, 66);
            lblIngresoDNI.Name = "lblIngresoDNI";
            lblIngresoDNI.Size = new System.Drawing.Size(87, 20);
            lblIngresoDNI.TabIndex = 7;
            lblIngresoDNI.Text = "lngrese DNI";
            // 
            // btnVolver
            // 
            btnVolver.Location = new System.Drawing.Point(443, 534);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(94, 29);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // InscribirActividad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 616);
            Controls.Add(btnVolver);
            Controls.Add(lblIngresoDNI);
            Controls.Add(btnBuscar);
            Controls.Add(lblClienteNombre);
            Controls.Add(txtDNI);
            Controls.Add(btnSalir);
            Controls.Add(btnInscribir);
            Controls.Add(dtgvDatos);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InscribirActividad";
            Text = "Inscribir Actividad";
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSesion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIngresoDNI;
        private Button btnVolver;
    }
}
