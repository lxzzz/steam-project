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
    public partial class frmJetCoe : Form
    {

        SysPar sysPar;
        WorkPar workPar;
        MixPar mixpar;
        EjePar ejepar;

        public frmJetCoe()
        {
            InitializeComponent();
            sysPar = DataShare.SysPar;
            workPar = DataShare.WorkPar;
            mixpar = DataShare.MixPar;
            ejepar = DataShare.EjePar;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDetJetCoe obj = new frmDetJetCoe();
            obj.MdiParent = this.MdiParent;
            obj.Show();
        }
    }
}
