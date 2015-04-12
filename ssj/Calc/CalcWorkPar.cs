using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj.Calc
{
    public class CalcWorkPar
    {
        Double kp;
        public Double Kp
        {
            get { return kp; }
            set { kp = value; }
        }
        Double px;
        public Double Px
        {
            get { return px; }
            set { px = value; }
        }
        Double apx;
        public Double Apx
        {
            get { return apx; }
            set { apx = value; }
        }
        public void cal(WorkPar workPar)
        {
            WFAdiCoe(workPar.WorkSpeHeaAtCP, workPar.WorkSpeHeaAtCV);
            WCIPreRat(kp);
            WFCriSpe(kp, workPar.TruWorkFluPre, workPar.WorkFluSV);
            // return this; 
        }


        public void WFAdiCoe(double cpp, double cvp)//     (Kp=Cpp/Cvp)     //WorkFluAdiCoe,
        {
            if (cvp == 0) kp = 0;
            else { kp = cpp / cvp; }
        }
        public void WCIPreRat(double kp) // ∏px=[2/(kp+1)]^[kp/(kp-1)]       //WorkCriIntPreRat   
        {
            if (kp == 1||kp==-1) px = 0;
            else { px = System.Math.Pow(2 / (kp + 1), kp / (kp - 1)); }
        }
        public void WFCriSpe(double kp, double pp, double vp)//apx={[2*(Kp/(Kp+1))]^0.5}*[(Pp*Vp)^0.5]      //WorkFluCriSpe
        {
            if (kp==-1) apx = 0;
            else
            {
                apx = System.Math.Pow(2 * (kp / (kp + 1)), 0.5) * System.Math.Pow(pp *1000000* vp, 0.5);//1000000是单位转换
            }
        }







        //public static List<double> fd(List<double> ss)
        //{
        //    List<double> sss = new List<double>();
        //    foreach (double x in ss)
        //    {
        //        sss.Add(x * 2);


        //    }
        //    return sss;//表的计算

        //}


    }




}
