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
    public partial class frmcajadetexto : Form
    {
        public frmcajadetexto()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
           frmprinicipal frmprinicipal = new frmprinicipal();
            frmprinicipal.ShowDialog();


        }
    }
}
