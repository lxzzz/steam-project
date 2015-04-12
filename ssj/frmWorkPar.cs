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
    public partial class frmWorkPar : Form//partial是一个类修饰符，用于把类定义拆分为几个部分，便于代码管理
    {
        SysPar sysPar;//确保构造函数结束后，

        public frmWorkPar()
        {
            InitializeComponent();
        }

        public frmWorkPar(SysPar _sysPar)//构造函数的方法名和类名一致
        {
            InitializeComponent();
            sysPar = _sysPar;//确保构造函数结束后，
            textBoxTruWorkFluPre.Text = (sysPar.WorkFluPre + sysPar.Atm).ToString();//计算实际工作流体压力
            radioButton2.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSysPar obj = new frmSysPar();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)//下一步
        {
            frmEjePar obj = new frmEjePar(sysPar);//把sysPar传入下一个窗体
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Hide();
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
                groupBox2.Enabled = true;//过热输入
            }
            else {
                groupBox2.Enabled = false;//饱和查表
            double work = double.Parse(textBoxTruWorkFluPre.Text);
            //MessageBox.Show(work.ToString());
            OleDbDataAdapter da = DBOperation.getAdapter(" SELECT * FROM param WHERE ABS(PM-" + work + ")=(SELECT MIN(ABS(PM-" + work + ")) FROM param)");
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow dr = ds.Tables[0].Rows[0];
            Parameters param = new Parameters(dr);
            textBoxWorkFluTem.Text = param.Tem.ToString();
            textBoxWorkFluEnt.Text = param.Sh.ToString();
            textBoxWorkFluSV.Text = param.Sv.ToString();
            textBoxWorkSpeHeaAtCP.Text = param.Scp.ToString();
            textBoxWorkSpeHeaAtCV.Text = param.Scv.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)//计算
        {




            WorkPar workPar = new WorkPar();
            workPar.WorkSpeHeaAtCP = Double.Parse(textBoxWorkSpeHeaAtCP.Text);//Cpp
            workPar.WorkSpeHeaAtCV = Double.Parse(textBoxWorkSpeHeaAtCV.Text);//Cvp
            workPar.TruWorkFluPre = Double.Parse(textBoxTruWorkFluPre.Text);//pp
            workPar.WorkFluSV = Double.Parse(textBoxWorkFluSV.Text);//vp


            DataShare.WorkPar = workPar;

            CalcWorkPar calcWorkPar = new CalcWorkPar();
            calcWorkPar.cal(workPar);

            textBoxWorkFluAdiCoe.Text = calcWorkPar.Kp.ToString();
            textBoxWorkCriIntPreRat.Text = calcWorkPar.Px.ToString();
            textBoxWorkFluCriSpe.Text = calcWorkPar.Apx.ToString();
        }
        

    }
}
