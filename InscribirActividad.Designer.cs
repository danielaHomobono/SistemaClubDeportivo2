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
            dtgvDatos = new System.Windows.Forms.DataGridView();
            Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgvDatos
            // 
            dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Nombre, Fecha, Docente, Precio });
            dtgvDatos.Location = new System.Drawing.Point(87, 93);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.RowTemplate.Height = 25;
            dtgvDatos.Size = new System.Drawing.Size(443, 150);
            dtgvDatos.TabIndex = 3;
            // dtgvDatos.CellContentClick += dtgvDatos_CellClick;
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
            Controls.Add(dtgvDatos);
            Name = "InscribirActividad";
            Text = "InscribirActividad";
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label1;
        // private EventHandler btnCarga_Click;
    }
}

