namespace pryMassaControlesBasicos
{
    partial class frmcajadetexto
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbienvenidos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbienvenidos
            // 
            this.lblbienvenidos.AutoSize = true;
            this.lblbienvenidos.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenidos.Location = new System.Drawing.Point(33, 59);
            this.lblbienvenidos.Name = "lblbienvenidos";
            this.lblbienvenidos.Size = new System.Drawing.Size(205, 30);
            this.lblbienvenidos.TabIndex = 1;
            this.lblbienvenidos.Text = "BIENVENIDOS";
            this.lblbienvenidos.Click += new System.EventHandler(this.lblbienvenidos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Escribir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmcajadetexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblbienvenidos);
            this.Name = "frmcajadetexto";
            this.Text = "principal";
            this.Load += new System.EventHandler(this.frmcajadetexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblbienvenidos;
        private System.Windows.Forms.Button button1;
    }
}

