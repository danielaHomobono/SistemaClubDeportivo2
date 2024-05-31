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
            lblTitulo = new System.Windows.Forms.Label();
            dtgvDatos = new System.Windows.Forms.DataGridView();
            Nombre_Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnInscribir = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            txtDNI = new System.Windows.Forms.TextBox();
            lblClienteNombre = new System.Windows.Forms.Label();
            btnBuscar = new System.Windows.Forms.Button();
            lblIngresoDNI = new System.Windows.Forms.Label();
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
            dtgvDatos.AllowUserToAddRows = false;
            dtgvDatos.AllowUserToDeleteRows = false;
            dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Nombre_Actividad, Fecha, Nombre_Profesor, Precio, idSesion });
            dtgvDatos.Location = new System.Drawing.Point(42, 178);
            dtgvDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.ReadOnly = true;
            dtgvDatos.RowHeadersWidth = 51;
            dtgvDatos.Size = new System.Drawing.Size(846, 333);
            dtgvDatos.TabIndex = 1;
            dtgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDatos.MultiSelect = true;

            // 
            // Nombre_Actividad
            // 
            Nombre_Actividad.HeaderText = "Nombre Actividad";
            Nombre_Actividad.MinimumWidth = 6;
            Nombre_Actividad.Name = "Nombre_Actividad";
            Nombre_Actividad.ReadOnly = true;
            Nombre_Actividad.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // Nombre_Profesor
            // 
            Nombre_Profesor.HeaderText = "Nombre Profesor";
            Nombre_Profesor.MinimumWidth = 6;
            Nombre_Profesor.Name = "Nombre_Profesor";
            Nombre_Profesor.ReadOnly = true;
            Nombre_Profesor.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // idSesion
            // 
            idSesion.HeaderText = "ID Sesión";
            idSesion.MinimumWidth = 6;
            idSesion.Name = "idSesion";
            idSesion.ReadOnly = true;
            idSesion.Visible = false;
            idSesion.Width = 125;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new System.Drawing.Point(261, 528);
            btnInscribir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            btnBuscar.Click += new EventHandler(btnBuscar_Click);
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
            // InscribirActividad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 616);
            Controls.Add(lblIngresoDNI);
            Controls.Add(btnBuscar);
            Controls.Add(lblClienteNombre);
            Controls.Add(txtDNI);
            Controls.Add(btnSalir);
            Controls.Add(btnInscribir);
            Controls.Add(dtgvDatos);
            Controls.Add(lblTitulo);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}
