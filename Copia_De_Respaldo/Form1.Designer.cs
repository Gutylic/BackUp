namespace Copia_De_Respaldo
{
    partial class Crear_BackUp
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_BackUp));
            this.BackUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackUp
            // 
            this.BackUp.BackColor = System.Drawing.Color.Brown;
            this.BackUp.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackUp.Location = new System.Drawing.Point(78, 45);
            this.BackUp.Name = "BackUp";
            this.BackUp.Size = new System.Drawing.Size(206, 95);
            this.BackUp.TabIndex = 0;
            this.BackUp.Text = "Back-Up";
            this.BackUp.UseVisualStyleBackColor = false;
            this.BackUp.Click += new System.EventHandler(this.BackUp_Click);
            // 
            // Crear_BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 198);
            this.Controls.Add(this.BackUp);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crear_BackUp";
            this.Text = "Base: \"Busqueda VPS_Supervisor\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackUp;
    }
}

