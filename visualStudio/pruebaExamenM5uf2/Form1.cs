using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaExamenM5uf2
{
    public partial class FrmMain : Form
    {
        FrmGroc frmGroc;
        FrmVerd frmVerd;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            frmGroc = new FrmGroc();

            frmGroc.WindowState = FormWindowState.Normal;
            frmGroc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVerd = new FrmVerd();

            frmVerd.WindowState = FormWindowState.Normal;
            frmVerd.Show();
        }
    }
}
