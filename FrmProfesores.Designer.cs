namespace SistemaClubDeportivo2
{
    partial class FrmProfesores
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
            dgtvProfesores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgtvProfesores).BeginInit();
            SuspendLayout();
            // 
            // dgtvProfesores
            // 
            dgtvProfesores.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dgtvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvProfesores.Dock = System.Windows.Forms.DockStyle.Fill;
            dgtvProfesores.Location = new System.Drawing.Point(0, 0);
            dgtvProfesores.Name = "dgtvProfesores";
            dgtvProfesores.RowHeadersWidth = 51;
            dgtvProfesores.RowTemplate.Height = 29;
            dgtvProfesores.Size = new System.Drawing.Size(834, 567);
            dgtvProfesores.TabIndex = 1;
            // 
            // FrmProfesores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(834, 567);
            Controls.Add(dgtvProfesores);
            Name = "FrmProfesores";
            Text = "FrmProfesores";
            ((System.ComponentModel.ISupportInitialize)dgtvProfesores).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgtvProfesores;
    }
}