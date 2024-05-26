using System;

namespace SistemaClubDeportivo2
{
    partial class InscribirActividad
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
            lblNombreAct = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            txtNombreAct = new System.Windows.Forms.TextBox();
            dtgvDatos = new System.Windows.Forms.DataGridView();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnCarga = new System.Windows.Forms.Button();
            lblProfesor = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            txtFecha = new System.Windows.Forms.TextBox();
            txtProfesor = new System.Windows.Forms.TextBox();
            txtPrecio = new System.Windows.Forms.TextBox();
            btnBorra = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblNombreAct
            // 
            lblNombreAct.AutoSize = true;
            lblNombreAct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreAct.Location = new System.Drawing.Point(30, 26);
            lblNombreAct.Name = "lblNombreAct";
            lblNombreAct.Size = new System.Drawing.Size(83, 21);
            lblNombreAct.TabIndex = 0;
            lblNombreAct.Text = "Actividad";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblFecha.Location = new System.Drawing.Point(30, 64);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(54, 21);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha";
            // 
            // txtNombreAct
            // 
            txtNombreAct.Location = new System.Drawing.Point(175, 28);
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new System.Drawing.Size(240, 23);
            txtNombreAct.TabIndex = 2;
            // 
            // dtgvDatos
            // 
            dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Nombre, Fecha, Docente, Precio });
            dtgvDatos.Location = new System.Drawing.Point(152, 234);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.RowTemplate.Height = 25;
            dtgvDatos.Size = new System.Drawing.Size(443, 150);
            dtgvDatos.TabIndex = 3;
            dtgvDatos.CellContentClick += dtgvDatos_CellClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Actividad";
            Nombre.Name = "Nombre";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Docente
            // 
            Docente.HeaderText = "Docente";
            Docente.Name = "Docente";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // btnCarga
            // 
            btnCarga.Location = new System.Drawing.Point(487, 28);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new System.Drawing.Size(75, 23);
            btnCarga.TabIndex = 4;
            btnCarga.Text = "Cargar";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProfesor.Location = new System.Drawing.Point(30, 100);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new System.Drawing.Size(74, 21);
            lblProfesor.TabIndex = 5;
            lblProfesor.Text = "Profesor";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrecio.Location = new System.Drawing.Point(30, 139);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(58, 21);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // txtFecha
            // 
            txtFecha.Location = new System.Drawing.Point(175, 62);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new System.Drawing.Size(240, 23);
            txtFecha.TabIndex = 7;
            // 
            // txtProfesor
            // 
            txtProfesor.Location = new System.Drawing.Point(175, 100);
            txtProfesor.Name = "txtProfesor";
            txtProfesor.Size = new System.Drawing.Size(240, 23);
            txtProfesor.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(175, 141);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(240, 23);
            txtPrecio.TabIndex = 9;
            // 
            // btnBorra
            // 
            btnBorra.Location = new System.Drawing.Point(487, 137);
            btnBorra.Name = "btnBorra";
            btnBorra.Size = new System.Drawing.Size(75, 23);
            btnBorra.TabIndex = 10;
            btnBorra.Text = "Borrar";
            btnBorra.UseVisualStyleBackColor = true;
            btnBorra.Click += btnBorra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 21);
            label1.TabIndex = 11;
            // 
            // InscribirActividad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBorra);
            Controls.Add(txtPrecio);
            Controls.Add(txtProfesor);
            Controls.Add(txtFecha);
            Controls.Add(lblPrecio);
            Controls.Add(lblProfesor);
            Controls.Add(btnCarga);
            Controls.Add(dtgvDatos);
            Controls.Add(txtNombreAct);
            Controls.Add(lblFecha);
            Controls.Add(lblNombreAct);
            Name = "InscribirActividad";
            Text = "InscribirActividad";
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombreAct;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombreAct;
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnBorra;
        private System.Windows.Forms.Label label1;
        // private EventHandler btnCarga_Click;
    }
}

