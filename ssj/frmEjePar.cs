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
    public partial class frmEjePar : Form
    {
        SysPar sysPar;
        public frmEjePar()
        {
            InitializeComponent();
        }
        public frmEjePar(SysPar _sysPar)
        {
            InitializeComponent();
            sysPar = _sysPar;
           textBoxTruEjeFluPre.Text = (sysPar.EjeFluPre + sysPar.Atm).ToString();//计算实际引射流体压力
            radioButton2.Checked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWorkPar obj = new frmWorkPar();
            obj.MdiParent = this.MdiParent;
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)//下一步
        {
            this.Hide();
            frmMixPar obj = new frmMixPar(sysPar);
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
                double work = double.Parse(textBoxTruEjeFluPre.Text);
                //MessageBox.Show(work.ToString());
                OleDbDataAdapter da = DBOperation.getAdapter(" SELECT * FROM param WHERE ABS(PM-" + work + ")=(SELECT MIN(ABS(PM-" + work + ")) FROM param)");
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow dr = ds.Tables[0].Rows[0];
                Parameters param = new Parameters(dr);
                textBoxEjeFluTem.Text = param.Tem.ToString();
                textBoxEjeFluEnt.Text = param.Sh.ToString();
                textBoxEjeFluSV.Text = param.Sv.ToString();
                textBoxEjeSpeHeaAtCP.Text = param.Scp.ToString();
                textBoxEjeSpeHeaAtCV.Text = param.Scv.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)//计算
        {

            EjePar ejePar = new EjePar();
            ejePar.EjeSpeHeaAtCP = Double.Parse(textBoxEjeSpeHeaAtCP.Text);//Cpp
            ejePar.EjeSpeHeaAtCV = Double.Parse(textBoxEjeSpeHeaAtCV.Text);//Cvp
            ejePar.TruEjeFluPre = Double.Parse(textBoxTruEjeFluPre.Text);//pp
            ejePar.EjeFluSV = Double.Parse(textBoxEjeFluSV.Text);//vp


            DataShare.EjePar = ejePar;
            CalcEjePar calcEjePar = new CalcEjePar();
            calcEjePar.cal(ejePar);

            textBoxEjeFluAdiCoe.Text = calcEjePar.Kh.ToString();
            textBoxEjeCriIntPreRat.Text = calcEjePar.Hx.ToString();
            textBoxEjeFluCriSpe.Text = calcEjePar.Ahx.ToString();
        }
    }
}
