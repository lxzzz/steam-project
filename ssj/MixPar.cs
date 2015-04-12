using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj
{
    public class MixPar
    {
        ////基本参数
        double truMixFluPre;
        /// <summary>
        /// 实际混合流体压力
        /// </summary>
        public double TruMixFluPre
        {
            get { return truMixFluPre; }
            set { truMixFluPre = value; }
        }
        double mixFluSV;
        /// <summary>
        /// 混合流体比容
        /// </summary>
        public double MixFluSV
        {
            get { return mixFluSV; }
            set { mixFluSV = value; }
        }
        double mixSpeHeaAtCP;
        /// <summary>
        /// 混合定压比热
        /// </summary>
        public double MixSpeHeaAtCP
        {
            get { return mixSpeHeaAtCP; }
            set { mixSpeHeaAtCP = value; }
        }
        double mixSpeHeaAtCV;
        /// <summary>
        /// 混合定容比热
        /// </summary>
        public double MixSpeHeaAtCV
        {
            get { return mixSpeHeaAtCV; }
            set { mixSpeHeaAtCV = value; }
        }
        ////计算参数
        double mixFluAdiCoe;
        /// <summary>
        /// 混合流体绝热系数
        /// </summary>
        public double MixFluAdiCoe
        {
            get { return mixFluAdiCoe; }
            set { mixFluAdiCoe = value; }
        }
        double mixCriIntPreRat;
        /// <summary>
        /// 混合流体临界界面压力比
        /// </summary>
        public double MixCriIntPreRat
        {
            get { return mixCriIntPreRat; }
            set { mixCriIntPreRat = value; }
        }
        double mixFluCriSpe;
        /// <summary>
        /// 混合流体临界速度
        /// </summary>
        public double MixFluCriSpe
        {
            get { return mixFluCriSpe; }
            set { mixFluCriSpe = value; }
        }

    }
}
