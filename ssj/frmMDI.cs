using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ssj
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }
        
        private void 气气喷射器SSJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSysPar obj = new frmSysPar();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
