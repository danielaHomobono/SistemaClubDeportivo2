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
            dtgvDatos.Location = new System.Drawing.Point(154, 264);
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
            btnInscribir.BackColor = System.Drawing.SystemColors.HotTrack;
            btnInscribir.Location = new System.Drawing.Point(154, 614);
            btnInscribir.Margin = new Padding(3, 4, 3, 4);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new System.Drawing.Size(114, 40);
            btnInscribir.TabIndex = 2;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            btnSalir.Location = new System.Drawing.Point(611, 614);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(114, 40);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new System.Drawing.Point(229, 119);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(161, 27);
            txtDNI.TabIndex = 4;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.AutoSize = true;
            lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblClienteNombre.Location = new System.Drawing.Point(125, 179);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new System.Drawing.Size(0, 28);
            lblClienteNombre.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscar.Location = new System.Drawing.Point(420, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(94, 38);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblIngresoDNI
            // 
            lblIngresoDNI.AutoSize = true;
            lblIngresoDNI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIngresoDNI.Location = new System.Drawing.Point(87, 119);
            lblIngresoDNI.Name = "lblIngresoDNI";
            lblIngresoDNI.Size = new System.Drawing.Size(114, 28);
            lblIngresoDNI.TabIndex = 7;
            lblIngresoDNI.Text = "lngrese DNI";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.SystemColors.HotTrack;
            btnVolver.Location = new System.Drawing.Point(407, 614);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(94, 40);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // InscribirActividad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 679);
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
