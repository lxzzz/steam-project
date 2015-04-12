using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj.Calc
{
    public class CalcMixPar
    {
        Double kc;
        public Double Kc
        {
            get { return kc; }
            set { kc = value; }
        }
        Double cx;
        public Double Cx
        {
            get { return cx; }
            set { cx = value; }
        }
        Double acx;
        public Double Acx
        {
            get { return acx; }
            set { acx = value; }
        }
        public void cal(MixPar MixPar)
        {
            MFAdiCoe(MixPar.MixSpeHeaAtCP, MixPar.MixSpeHeaAtCV);
            MCIPreRat(kc);
            MFCriSpe(kc, MixPar.TruMixFluPre, MixPar.MixFluSV);
            // return this; 
        }


        public void MFAdiCoe(double cpc, double cvc)//     (Kc=Cpc/Cvc)     //MixFluAdiCoe,
        {
            if (cvc == 0) kc = 0;
            else { kc = cpc / cvc; }
        }
        public void MCIPreRat(double kc) // ∏cx=[2/(kc+1)]^[kc/(kc-1)]       //MixCriIntPreRat   
        {
            if (kc == 1 || kc == -1) cx = 0;
            else { cx = System.Math.Pow(2 / (kc + 1), kc / (kc - 1)); }
        }
        public void MFCriSpe(double kc, double pc, double vc)//acx={[2*(Kc/Kc+1)]^0.5}*[(Pc*Vc)^0.5]      //MixFluCriSpe
        {
            if (kc == -1) acx = 0;
            else
            {
                acx = System.Math.Pow(2 * (kc / (kc + 1)), 0.5) * System.Math.Pow(pc * 1000000 * vc, 0.5);//1000000是单位转换
            }
        }
    }
}
