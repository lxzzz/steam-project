using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj.Calc
{
    public class CalcEjePar
    {
        Double kh;
        public Double Kh
        {
            get { return kh; }
            set { kh = value; }
        }
        Double hx;
        public Double Hx
        {
            get { return hx; }
            set { hx = value; }
        }
        Double ahx;
        public Double Ahx
        {
            get { return ahx; }
            set { ahx = value; }
        }
        public void cal(EjePar EjePar)
        {
            EFAdiCoe(EjePar.EjeSpeHeaAtCP, EjePar.EjeSpeHeaAtCV);
            ECIPreRat(kh);
            EFCriSpe(kh, EjePar.TruEjeFluPre, EjePar.EjeFluSV);
            // return this; 
        }


        public void EFAdiCoe(double cph, double cvh)//     (Kh=Cph/Cvh)     //EjeFluAdiCoe,
        {
            if (cvh == 0) kh = 0;
            else { kh = cph / cvh; }
        }
        public void ECIPreRat(double kh) // ∏hx=[2/(kh+1)]^[kh/(kh-1)]       //EjeCriIntPreRat   
        {
            if (kh == 1 || kh == -1) hx = 0;
            else { hx = System.Math.Pow(2 / (kh + 1), kh / (kh - 1)); }
        }
        public void EFCriSpe(double kh, double ph, double vh)//ahx={[2*(Kh/Kh+1)]^0.5}*[(Ph*Vh)^0.5]      //EjeFluCriSpe
        {
            if (kh == -1) ahx = 0;
            else
            {
                ahx = System.Math.Pow(2 * (kh / (kh + 1)), 0.5) * System.Math.Pow(ph * 1000000 * vh, 0.5);//1000000是单位转换
            }
        }
    }
}
