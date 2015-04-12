using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ssj
{
   public class SysPar
    {
        //public SysPar(double x) { workFluPre = x; }
        //workFluPre工作流体压力
        //double workFluPre;
        //public double getWorkFluPre()
        //{
        //    return workFluPre;
        //}
        //public void setWorkFluPre(double x)
        //{
        //    workFluPre = x;
        //}
        double workFluPre;
        ///<summary>
        ///工作流体压力
        ///</summary>
        public double WorkFluPre

        {
            get { return workFluPre; }
            set { workFluPre = value; }
        }

        double ejeFluPre;
        ///<summary>
        ///引射流体压力 
        ///</summary>
        public double EjeFluPre
        {
            get { return ejeFluPre; }
            set { ejeFluPre = value; }
        }

        double ejeFluFlo;
       /// <summary>
        ///引射流体流量
       /// </summary>
        public double EjeFluFlo
        {
            get { return ejeFluFlo; }
            set { ejeFluFlo = value; }
        }
        
        double mixFluPre;
       /// <summary>
        ///混合流体压力
       /// </summary>
        public double MixFluPre
        {
            get { return mixFluPre; }
            set { mixFluPre = value; }
        }
        double atm;
       /// <summary>
        /// 当地大气压
       /// </summary>
        public double Atm
        {
            get { return atm; }
            set { atm = value; }
        }
     }
}
