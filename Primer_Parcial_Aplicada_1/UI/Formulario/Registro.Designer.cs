namespace Primer_Parcial_Aplicada_1.IU.Formulario
{
    partial class Registro
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
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.Color.Honeydew;
            this.Buscarbutton.Image = global::Primer_Parcial_Aplicada_1.Properties.Resources.Search_32;
            this.Buscarbutton.Location = new System.Drawing.Point(245, 46);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(72, 39);
            this.Buscarbutton.TabIndex = 27;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.Color.Honeydew;
            this.Eliminarbutton.Image = global::Primer_Parcial_Aplicada_1.Properties.Resources.Delete_Trash_32;
            this.Eliminarbutton.Location = new System.Drawing.Point(227, 354);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(72, 43);
            this.Eliminarbutton.TabIndex = 26;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.Color.Honeydew;
            this.Guardarbutton.Image = global::Primer_Parcial_Aplicada_1.Properties.Resources.filesaveas_32;
            this.Guardarbutton.Location = new System.Drawing.Point(123, 354);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(71, 43);
            this.Guardarbutton.TabIndex = 25;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.Color.Honeydew;
            this.Nuevobutton.Image = global::Primer_Parcial_Aplicada_1.Properties.Resources.Add_File_32;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 354);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(71, 43);
            this.Nuevobutton.TabIndex = 24;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 410);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
    }
}