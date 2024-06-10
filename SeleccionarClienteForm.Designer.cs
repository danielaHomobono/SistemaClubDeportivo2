namespace SistemaClubDeportivo2
{
    partial class SeleccionarClienteForm
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
            listBoxClientes = new System.Windows.Forms.ListBox();
            btnAceptar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 20;
            listBoxClientes.Location = new System.Drawing.Point(12, 46);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new System.Drawing.Size(776, 284);
            listBoxClientes.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new System.Drawing.Point(333, 394);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(94, 29);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // SeleccionarClienteForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(listBoxClientes);
            Name = "SeleccionarClienteForm";
            Text = "SeleccionarClienteForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button btnAceptar;
    }
}