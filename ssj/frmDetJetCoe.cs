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
    public partial class frmDetJetCoe : Form
    {
        public frmDetJetCoe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSize obj = new frmSize();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            //frmSize fm6 = new frmSize();
            //fm6.Visible = true;
            //// this.Close();
            //fm6.Show();//显示FormSize窗口
            //this.Visible = false;//隐藏FormDetEjectorCoe窗口
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJetCoe obj = new frmJetCoe();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            //frmJetCoe fm6 = new frmJetCoe();
            //fm6.Visible = true;
            //// this.Close();
            //fm6.Show();//显示FormEjectorCoe窗口
            //this.Visible = false;//隐藏FormDetEjectorCoe窗口
        }
       
    }
}
