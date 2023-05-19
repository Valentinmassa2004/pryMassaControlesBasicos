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
            this.btningresar = new System.Windows.Forms.Button();
            this.lblbienvenidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(131, 301);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 0;
            this.btningresar.Text = "ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            // 
            // lblbienvenidos
            // 
            this.lblbienvenidos.AutoSize = true;
            this.lblbienvenidos.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenidos.Location = new System.Drawing.Point(62, 144);
            this.lblbienvenidos.Name = "lblbienvenidos";
            this.lblbienvenidos.Size = new System.Drawing.Size(205, 30);
            this.lblbienvenidos.TabIndex = 1;
            this.lblbienvenidos.Text = "BIENVENIDOS";
            // 
            // frmcajadetexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.lblbienvenidos);
            this.Controls.Add(this.btningresar);
            this.Name = "frmcajadetexto";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Label lblbienvenidos;
    }
}

