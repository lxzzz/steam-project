using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ssj.Model;
using ssj.Calc;

namespace ssj
{
    public partial class frmMixPar : Form
    {
        SysPar sysPar;
        public frmMixPar()
        {
            InitializeComponent();
        }
        public frmMixPar(SysPar _syspar)
        {
            InitializeComponent();
            sysPar = _syspar;
            textBoxTruMixFluPre.Text = (sysPar.MixFluPre + sysPar.Atm).ToString();//计算实际工作流体压力
            radioButton2.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEjePar obj = new frmEjePar();
            obj.MdiParent = this.MdiParent;
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)//下一步
        {
            this.Hide();
            frmJetCoe obj = new frmJetCoe();
            obj.MdiParent = this.MdiParent;
            obj.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changeState();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changeState();
        }

        private void changeState()
        {
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;//过热输入
            }
            else
            {
                groupBox1.Enabled = false;//饱和查表
                double mix = double.Parse(textBoxTruMixFluPre.Text);
                //MessageBox.Show(mix.ToString());
                OleDbDataAdapter da = DBOperation.getAdapter(" SELECT * FROM param WHERE ABS(PM-" + mix + ")=(SELECT MIN(ABS(PM-" + mix+ ")) FROM param)");
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow dr = ds.Tables[0].Rows[0];
                Parameters param = new Parameters(dr);
                textBoxMixFluSV.Text = param.Sv.ToString();
                textBoxMixSpeHeaAtCP.Text = param.Scp.ToString();
                textBoxMixSpeHeaAtCV.Text = param.Scv.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)//计算
        {

            MixPar mixPar = new MixPar();
            mixPar.MixSpeHeaAtCP = Double.Parse(textBoxMixSpeHeaAtCP.Text);//Cpp
            mixPar.MixSpeHeaAtCV = Double.Parse(textBoxMixSpeHeaAtCV.Text);//Cvp
            mixPar.TruMixFluPre = Double.Parse(textBoxTruMixFluPre.Text);//pp
            mixPar.MixFluSV = Double.Parse(textBoxMixFluSV.Text);//vp


            DataShare.MixPar = mixPar;

            CalcMixPar calcMixPar = new CalcMixPar();
            calcMixPar.cal(mixPar);

            textBoxMixFluAdiCoe.Text = calcMixPar.Kc.ToString();
            textBoxMixCriIntPreRat.Text = calcMixPar.Cx.ToString();
            textBoxMixFluCriSpe.Text = calcMixPar.Acx.ToString();
        }
    }
}
