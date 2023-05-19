namespace pryMassaControlesBasicos
{
    partial class frmprinicipal
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
            this.txtcajadetexto = new System.Windows.Forms.TextBox();
            this.chkmayonesa = new System.Windows.Forms.CheckBox();
            this.chkketchup = new System.Windows.Forms.CheckBox();
            this.btnasignar = new System.Windows.Forms.Button();
            this.chkpicante = new System.Windows.Forms.CheckBox();
            this.rdbazul = new System.Windows.Forms.RadioButton();
            this.rdbrojo = new System.Windows.Forms.RadioButton();
            this.cboadicional = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcajadetexto
            // 
            this.txtcajadetexto.Location = new System.Drawing.Point(65, 27);
            this.txtcajadetexto.Name = "txtcajadetexto";
            this.txtcajadetexto.Size = new System.Drawing.Size(100, 20);
            this.txtcajadetexto.TabIndex = 0;
            this.txtcajadetexto.TextChanged += new System.EventHandler(this.txtcajadetexto_TextChanged);
            // 
            // chkmayonesa
            // 
            this.chkmayonesa.AutoSize = true;
            this.chkmayonesa.Location = new System.Drawing.Point(37, 164);
            this.chkmayonesa.Name = "chkmayonesa";
            this.chkmayonesa.Size = new System.Drawing.Size(74, 17);
            this.chkmayonesa.TabIndex = 1;
            this.chkmayonesa.Text = "mayonesa";
            this.chkmayonesa.UseVisualStyleBackColor = true;
            this.chkmayonesa.CheckedChanged += new System.EventHandler(this.chkrojo_CheckedChanged);
            // 
            // chkketchup
            // 
            this.chkketchup.AutoSize = true;
            this.chkketchup.Location = new System.Drawing.Point(37, 187);
            this.chkketchup.Name = "chkketchup";
            this.chkketchup.Size = new System.Drawing.Size(65, 17);
            this.chkketchup.TabIndex = 2;
            this.chkketchup.Text = "ketchup";
            this.chkketchup.UseVisualStyleBackColor = true;
            this.chkketchup.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnasignar
            // 
            this.btnasignar.Location = new System.Drawing.Point(81, 98);
            this.btnasignar.Name = "btnasignar";
            this.btnasignar.Size = new System.Drawing.Size(75, 23);
            this.btnasignar.TabIndex = 3;
            this.btnasignar.Text = "asignar";
            this.btnasignar.UseVisualStyleBackColor = true;
            this.btnasignar.Click += new System.EventHandler(this.btnasignar_Click);
            // 
            // chkpicante
            // 
            this.chkpicante.AutoSize = true;
            this.chkpicante.Location = new System.Drawing.Point(37, 210);
            this.chkpicante.Name = "chkpicante";
            this.chkpicante.Size = new System.Drawing.Size(61, 17);
            this.chkpicante.TabIndex = 4;
            this.chkpicante.Text = "picante";
            this.chkpicante.UseVisualStyleBackColor = true;
            // 
            // rdbazul
            // 
            this.rdbazul.AutoSize = true;
            this.rdbazul.Location = new System.Drawing.Point(134, 64);
            this.rdbazul.Name = "rdbazul";
            this.rdbazul.Size = new System.Drawing.Size(45, 17);
            this.rdbazul.TabIndex = 5;
            this.rdbazul.TabStop = true;
            this.rdbazul.Text = "Azul";
            this.rdbazul.UseVisualStyleBackColor = true;
            // 
            // rdbrojo
            // 
            this.rdbrojo.AutoSize = true;
            this.rdbrojo.Location = new System.Drawing.Point(37, 64);
            this.rdbrojo.Name = "rdbrojo";
            this.rdbrojo.Size = new System.Drawing.Size(47, 17);
            this.rdbrojo.TabIndex = 6;
            this.rdbrojo.TabStop = true;
            this.rdbrojo.Text = "Rojo";
            this.rdbrojo.UseVisualStyleBackColor = true;
            this.rdbrojo.CheckedChanged += new System.EventHandler(this.rdbrojo_CheckedChanged);
            // 
            // cboadicional
            // 
            this.cboadicional.FormattingEnabled = true;
            this.cboadicional.Location = new System.Drawing.Point(297, 252);
            this.cboadicional.Name = "cboadicional";
            this.cboadicional.Size = new System.Drawing.Size(121, 21);
            this.cboadicional.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(27, 265);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // frmprinicipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 606);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.cboadicional);
            this.Controls.Add(this.rdbrojo);
            this.Controls.Add(this.rdbazul);
            this.Controls.Add(this.chkpicante);
            this.Controls.Add(this.btnasignar);
            this.Controls.Add(this.chkketchup);
            this.Controls.Add(this.chkmayonesa);
            this.Controls.Add(this.txtcajadetexto);
            this.Name = "frmprinicipal";
            this.Text = "principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcajadetexto;
        private System.Windows.Forms.CheckBox chkmayonesa;
        private System.Windows.Forms.CheckBox chkketchup;
        private System.Windows.Forms.Button btnasignar;
        private System.Windows.Forms.CheckBox chkpicante;
        private System.Windows.Forms.RadioButton rdbazul;
        private System.Windows.Forms.RadioButton rdbrojo;
        private System.Windows.Forms.ComboBox cboadicional;
        private System.Windows.Forms.Button btnagregar;
    }
}