using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ssj.Model;
namespace ssj
{
    public partial class frmSysPar : Form
    {

        public frmSysPar()
        {
            InitializeComponent();
            //.NET平台自动执行的，是做一些初始化的工作，例如： 初始化FORM，上面的控件，加载资源，分配资源等
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da=DBOperation.getAdapter("select * from material");
            DataSet ds = new DataSet();
            da.Fill(ds);
           // List<Material> materialList = new List<Material>();

            foreach (DataRow dr in ds.Tables[0].Rows) {
                Material m=new Material(dr);
           //     materialList.Add(m);
                cmbMaterialType.Items.Add(m.MaterialName);
            }

            // TODO:  这行代码将数据加载到表“dbDataSet.material”中。您可以根据需要移动或删除它。


            // TODO:  这行代码将数据加载到表“dbDataSet.material”中。您可以根据需要移动或删除它。
            // TODO:  这行代码将数据加载到表“dbDataSet.material”中。您可以根据需要移动或删除它。
            //OleDbConnection cn = new OleDbConnection();
            //OleDbCommand cm = new OleDbCommand();
            //OleDbDataAdapter da = new OleDbDataAdapter();
            //string sql = "select MATERIAL from material ";
            //Class1.ComboBind(cmbMaterialType, sql, "班级名称", "班级代码");
            //if (cmbMaterialType.Items.Count > 0)
            //{
            //    cmbMaterialType.SelectedIndex = 0;
            //    //cmbMaterialType_SelectedIndexChanged(cmbMaterialType, e);
            //}
            //else
            //{
            //    cmbMaterialType.Text = "年级没有班级！";
            //}

        }




         
        private void button1_Click(object sender, EventArgs e)//下一步
        {
            SysPar sysPar = new SysPar();
            sysPar.EjeFluPre = Double.Parse(textBoxEjeFluPre.Text);
            sysPar.WorkFluPre = Double.Parse(textBoxWorkFluPre.Text);
            sysPar.MixFluPre = Double.Parse(textBoxMixFluPre.Text);
            sysPar.Atm = Double.Parse(textBoxAtm.Text);//get,set方法
            frmWorkPar obj = new frmWorkPar(sysPar);

            DataShare.SysPar = sysPar;

            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Hide();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    SysPar x=new SysPar();
        //    x.setWorkflu(Double.Parse(textBoxWorkFluPre.Text));

        //   // double s=func.calc(x, x, x);
        //   // textBoxThrEntCoe.Text = s.ToString();
        //   // Class1 c = new Class1();
        //   // c.getbbbbb();
        //   //List<double> fun11c=func.fd(c.getbbbbb());
        //}

      

        //键事件按下列顺序发生:KeyDown,KeyPress,KeyUp
        //非字符键不会引发 KeyPress 事件,但非字符键却可以引发 KeyDown 和 KeyUp 事件.
        //使用 KeyChar 属性在运行时对键击进行取样，并且使用或修改公共键击的子集.
        //若要仅在窗体级别处理键盘事件而不允许其他控件接收键盘事件,
        //请将窗体的 KeyPress 事件处理方法中的 KeyPressEventArgs.Handled 属性设置为 true.
        private void textBoxWorkFluPre_KeyPress(object sender,KeyPressEventArgs e)//System.Windows.Forms.
        {
            //判断输入的工作流体压力是否为数(整数或小数)
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)//(char)8是退格键的键值,char(13)回车键
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("只能输入数字和小数点!");
                    }
                }
                else
                {
                    e.Handled = false;
                }
        }

        //private void textBoxEjeFluPre_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //判断输入的引射流体压力是否为数（整数或小数）
        //    if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
        //    {
        //        if (e.KeyChar == '.')
        //        {
        //            e.Handled = false;
        //        }
        //        else
        //        {
        //            e.Handled = true;
        //            MessageBox.Show("只能输入数字和小数点!");
        //        }
        //    }
        //    else
        //    {
        //        e.Handled = false;
        //    }
        //}

        private void textBoxEjeFluFlo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断输入的引射流体流量是否为数（整数或小数）
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("只能输入数字和小数点!");
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxMixFluPre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断输入的混合流体压力是否为数（整数或小数）
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("只能输入数字和小数点!");
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxAtm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断输入的当地大气压是否为数（整数或小数）
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("只能输入数字和小数点!");
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxNozCoe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断输入的喷嘴流速系数是否为数（整数或小数）
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("只能输入数字和小数点!");
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxThrCoe_KeyPress(object sender, KeyPressEventArgs e)
        {

            //判断输入的喉管流速系数是否为数（整数或小数）
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("只能输入数字和小数点!");
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxDifCoe_KeyPress(object sender, KeyPressEventArgs e)
        {

            //判断输入的扩散管流速系数是否为数（整数或小数）
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("只能输入数字和小数点!");
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBoxThrEntCoe_KeyPress(object sender, KeyPressEventArgs e)
        {

            //判断输入的喉管入口处流速系数是否为数（整数或小数）
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("只能输入数字和小数点!");
                }
            }
            else
            {
                e.Handled = false;
            }
        }

    }
}
