using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMassaControlesBasicos
{
    public partial class frmprinicipal : Form
    {
        private object txtreflejo;

        public frmprinicipal()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkrojo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbmayonesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            if (rdbazul.Checked == true)
            {
                lblReflejo.ForeColor = Color.Blue;
                txtcajadetexto.ForeColor = Color.Blue;
            }
            if (rdbrojo.Checked == true)
            {
                lblReflejo.ForeColor = Color.Red;
                txtcajadetexto.ForeColor = Color.Red;
            }
        }

        private void rdbrojo_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void txtcajadetexto_TextChanged(object sender, EventArgs e)
        {
            lblReflejo.Text = txtcajadetexto.Text;  
}

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string textoConcatenar = "";
            if (chkpicante.Checked == true)
            {
                lblMostrar.Text = "Picante";
                textoConcatenar = textoConcatenar + "Picante";
            }
            if (chkmayonesa.Checked == true)
            {
                lblMostrar.Text = "Mayonesa";
                textoConcatenar = textoConcatenar + " Mayonesa";
            }
            if (chkketchup.Checked == true)
            {
                lblMostrar.Text = "Kethup";
                textoConcatenar = textoConcatenar + " Ketchup";
            }

            lblMostrar.Text = textoConcatenar;
            cboagregar.Items.Add(textoConcatenar);
        }
    }
    }
