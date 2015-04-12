using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj
{
    public class WorkPar
    {
        ////基本参数部分
        double truWorkFluPre;
        /// <summary>
        /// 实际工作参数
        /// </summary>
        public double TruWorkFluPre
        {
            get {return truWorkFluPre; }
            set {truWorkFluPre=value;}
        }
        double workFluTem;
        /// <summary>
        /// 工作流体温度
        /// </summary>
        public double WorkFluTem
        {
            get { return workFluTem; }
            set { workFluTem = value; }
        }
        double workFluEnt;
        /// <summary>
        /// 工作流体焓值
        /// </summary>
        public double WorkFluEnt
        {
            get { return workFluEnt; }
            set { workFluEnt = value; }
        }
        double workFluSV;
        /// <summary>
        /// 工作流体比容
        /// </summary>
        public double WorkFluSV
        {
            get { return workFluSV; }
            set { workFluSV = value; }
        }

        double workSpeHeaAtCP;
        /// <summary>
        /// 工作定压比热
        /// </summary>
        public double WorkSpeHeaAtCP
        {
            get { return workSpeHeaAtCP; }
            set { workSpeHeaAtCP = value; }
        }
        double workSpeHeaAtCV;
        /// <summary>
        /// 工作定容比热
        /// </summary>
        public double WorkSpeHeaAtCV
        {
            get { return workSpeHeaAtCV; }
            set { workSpeHeaAtCV = value; }
        }
        ////计算参数部分
        double workFluAdiCoe;
        /// <summary>
        /// 工作流体绝热系数
        /// </summary>
        public double WorkFluAdiCoe
        {
            get { return workFluAdiCoe; }
            set { workFluAdiCoe = value; }
        }
        double workCriIntPreRat;
        /// <summary>
        /// 工作临界界面压力比(∏px)
        /// </summary>
        public double WorkCriIntPreRat
        {
            get { return workCriIntPreRat; }
            set { workCriIntPreRat = value; }
        }
        double workFluCriSpe;
        /// <summary>
        /// 工作流体临界速度
        /// </summary>
        public double WorkFluCriSpe
        {
            get { return workFluCriSpe; }
            set { workFluCriSpe = value; }
        }


    }
}
