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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Nombre_Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(200, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Inscripción a Actividades";
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.AllowUserToDeleteRows = false;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Actividad,
            this.Fecha,
            this.Nombre_Profesor,
            this.Precio,
            this.idSesion});
            this.dtgvDatos.Location = new System.Drawing.Point(30, 70);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.ReadOnly = true;
            this.dtgvDatos.Size = new System.Drawing.Size(740, 250);
            this.dtgvDatos.TabIndex = 1;
            // 
            // Nombre_Actividad
            // 
            this.Nombre_Actividad.HeaderText = "Nombre Actividad";
            this.Nombre_Actividad.Name = "Nombre_Actividad";
            this.Nombre_Actividad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Nombre_Profesor
            // 
            this.Nombre_Profesor.HeaderText = "Nombre Profesor";
            this.Nombre_Profesor.Name = "Nombre_Profesor";
            this.Nombre_Profesor.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // idSesion
            // 
            this.idSesion.HeaderText = "ID Sesión";
            this.idSesion.Name = "idSesion";
            this.idSesion.ReadOnly = true;
            this.idSesion.Visible = false; // Ocultamos la columna
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(200, 340);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(100, 30);
            this.btnInscribir.TabIndex = 2;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(400, 340);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // InscribirActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "InscribirActividad";
            this.Text = "Inscribir Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
