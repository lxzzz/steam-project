using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj
{
    public class JetCoe
    {
        ////计算参数
        double workFluExpRat;
        /// <summary>
        /// 工作流体膨胀比
        /// </summary>
        public double WorkFluExpRat
        {
            get { return workFluExpRat; }
            set { workFluExpRat = value; }
        }
        double ejeFluComRat;
        /// <summary>
        /// 引射流体压缩比
        /// </summary>
        public double EjeFluComRat
        {
            get { return ejeFluComRat; }
            set { ejeFluComRat = value; }
        }
        double workFluIseSpeCoe;
        /// <summary>
        /// 工作流体2-2断面等熵速度系数
        /// </summary>
        public double WorkFluIseSpeCoe
        {
            get { return workFluIseSpeCoe; }
            set { workFluIseSpeCoe = value; }
        }

        double workFluMassSpeCoe;
        /// <summary>
        /// 工作流体2-2断面质量速度系数
        /// </summary>
        public double WorkFluMassSpeCoe
        {
            get { return workFluMassSpeCoe; }
            set { workFluMassSpeCoe = value; }
        }
        double k1;
        /// <summary>
        /// k1
        /// </summary>
        public double K1
        {
            get { return k1; }
            set { k1 = value; }
        }
        double k2;
        /// <summary>
        /// k2
        /// </summary>
        public double K2
        {
            get { return k2; }
            set { k2 = value; }
        }
        ////基本参数
        double fsVF3;
        /// <summary>
        /// fs和f3面积比
        /// </summary>
        public double FsVF3
        {
            get { return fsVF3; }
            set { fsVF3 = value; }
        }
        double f2VF3;
        /// <summary>
        /// f2和f3面积比
        /// </summary>
        public double F2VF3
        {
            get { return f2VF3; }
            set { f2VF3 = value; }
        }
        double a;
        /// <summary>
        /// a
        /// </summary>
        public double A
        {
            get { return a; }
            set { a = value; }
        }
    }
}
