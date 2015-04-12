using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj
{
   public class EjePar
    {
        ////基本参数部分
        double truEjeFluPre;
       /// <summary>
        /// 实际引射流体压力
       /// </summary>
        public double TruEjeFluPre
        {
            get { return truEjeFluPre; }
            set { truEjeFluPre = value; }
        }
        double ejeFluTem;
       /// <summary>
        /// 引射流体温度
       /// </summary>
        public double EjeFluTem
        {
            get { return ejeFluTem; }
            set { ejeFluTem = value; }
        }
        double ejeFluEnt;
       /// <summary>
        /// 引射流体焓值
       /// </summary>
        public double EjeFluEnt
        {
            get { return ejeFluEnt; }
            set { ejeFluEnt = value; }
        }

        double ejeFluSV;
       /// <summary>
        /// 引射流体比容
       /// </summary>
        public double EjeFluSV
        {
            get { return ejeFluSV; }
            set { ejeFluSV = value; }
        }
        double ejeSpeHeaAtCP;
       /// <summary>
        /// 引射定压比热
       /// </summary>
        public double EjeSpeHeaAtCP
        {
            get { return ejeSpeHeaAtCP; }
            set { ejeSpeHeaAtCP = value; }
        }
        double ejeSpeHeaAtCV;
       /// <summary>
        /// 引射定容比热
       /// </summary>
        public double EjeSpeHeaAtCV
        {
            get { return ejeSpeHeaAtCV; }
            set { ejeSpeHeaAtCV = value; }
        }
        ////计算参数
        double ejeFluAdiCoe;
       /// <summary>
        /// 引射流体绝热系数
       /// </summary>
        public double EjeFluAdiCoe
        {
            get { return ejeFluAdiCoe; }
            set { ejeFluAdiCoe = value; }
        }
        double ejeCriIntPreRat;
       /// <summary>
        /// 引射临界界面压力比
       /// </summary>
        public double EjeCriIntPreRat
        {
            get { return ejeCriIntPreRat; }
            set { ejeCriIntPreRat = value; }
        }
        double ejeFluCriSpe;
       /// <summary>
        /// 引射流体临界速度
       /// </summary>
        public double EjeFluCriSpe
        {
            get { return ejeFluCriSpe; }
            set { ejeFluCriSpe = value; }
        }

    }
}
