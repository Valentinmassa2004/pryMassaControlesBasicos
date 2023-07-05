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
        Random random = new Random();
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

        private void frmControlesBasicos_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int maxWidth = this.Width - lblbienvenidos.Width;
            int maxHeight = this.Height - lblbienvenidos.Height;
            lblbienvenidos.Location = new Point(random.Next(maxWidth), random.Next(maxHeight));
        }

        private void frmControlesBasicos_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void frmControlesBasicos_Click(object sender, EventArgs e)
        {
            lblbienvenidos.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmprinicipal frmprinicipal = new frmprinicipal();
            frmprinicipal.ShowDialog();   
        }
        private void lblbienvenidos_MouseMove(object sender, MouseEventArgs e)
        {
            lblbienvenidos.Location = new Point(random.Next(10, 850), random.Next(10, 850));
        }
    }
}

