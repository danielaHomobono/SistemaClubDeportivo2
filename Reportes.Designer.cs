namespace SistemaClubDeportivo2
{
    partial class Reportes
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
            lblListado = new System.Windows.Forms.Label();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgvDatos
            // 
            dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2 });
            dtgvDatos.Location = new System.Drawing.Point(12, 164);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.RowHeadersWidth = 51;
            dtgvDatos.RowTemplate.Height = 29;
            dtgvDatos.Size = new System.Drawing.Size(500, 188);
            dtgvDatos.TabIndex = 0;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Location = new System.Drawing.Point(110, 56);
            lblListado.Name = "lblListado";
            lblListado.Size = new System.Drawing.Size(275, 20);
            lblListado.TabIndex = 1;
            lblListado.Text = "Listado de clientes con cuota por vencer";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblListado);
            Controls.Add(dtgvDatos);
            Name = "Reportes";
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}