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

        private void lblbienvenidos_Click(object sender, EventArgs e)
        {

        }

        private void frmcajadetexto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmprinicipal frmprinicipal = new frmprinicipal();
            frmprinicipal.ShowDialog();   
        }
    }
}

