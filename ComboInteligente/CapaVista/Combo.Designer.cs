namespace CapaVista
{
    partial class Combo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cbo_Auto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Cbo_Auto
            // 
            this.Cbo_Auto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cbo_Auto.FormattingEnabled = true;
            this.Cbo_Auto.Location = new System.Drawing.Point(0, 0);
            this.Cbo_Auto.Name = "Cbo_Auto";
            this.Cbo_Auto.Size = new System.Drawing.Size(245, 21);
            this.Cbo_Auto.TabIndex = 0;
            // 
            // Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cbo_Auto);
            this.Name = "Combo";
            this.Size = new System.Drawing.Size(245, 29);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_Auto;
    }
}
