using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LmRk4Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xvsyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LorentzModelC obj = new LorentzModelC(10, (8.0 / 3), 25, 5000, 1, 0, 0, 0);
            obj.process();
            obj.plotx_vs_y(this);
        }

        private void xvstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LorentzModelC obj = new LorentzModelC(10, (8.0 / 3), 25, 5000, 1, 0, 0, 0);
            obj.process();
            obj.plotx_vs_t(this);
        }

        private void zvsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LorentzModelC obj = new LorentzModelC(10, (8.0 / 3), 25, 5000, 1, 0, 0, 0);
            obj.process();
            obj.plotz_vs_x(this);
        }
    }
}
