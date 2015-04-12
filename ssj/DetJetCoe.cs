using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj
{
    public class DetJetCoe
    {
        ////校核U值
        double desEjeCoe;
        /// <summary>
        /// 设计引射系数
        /// </summary>
        public double DesEjeCoe
        {
            get { return desEjeCoe; }
            set { desEjeCoe = value; }
        }
        ////计算参数
        double workFluFlo;
        /// <summary>
        /// 工作流体流量
        /// </summary>
        public double WorkFluFlo
        {
            get { return workFluFlo; }
            set { workFluFlo = value; }
        }
        double mixFluFlo;
        /// <summary>
        /// 混合流体流量
        /// </summary>
        public double MixFluFlo
        {
            get { return mixFluFlo; }
            set { mixFluFlo = value; }
        }
        double mixFluEnt;
        /// <summary>
        /// 混合流体焓值
        /// </summary>
        public double MixFluEnt
        {
            get { return mixFluEnt; }
            set { mixFluEnt = value; }
        }
        double mixFluPre;
        /// <summary>
        /// 混合流体压力
        /// </summary>
        public double MixFluPre
        {
            get { return mixFluPre; }
            set { mixFluPre = value; }
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
        double cOP;
        /// <summary>
        /// 供热系数
        /// </summary>
        public double COP
        {
            get { return cOP; }
            set { cOP = value; }
        }
        double ejeFluMassSpeCoe;
        /// <summary>
        /// 引射流体2-2断面的质量速度系数
        /// </summary>
        public double EjeFluMassSpeCoe
        {
            get { return ejeFluMassSpeCoe; }
            set { ejeFluMassSpeCoe = value; }
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
        double ejeFluCriSpe;
        /// <summary>
        /// 引射流体临界速度
        /// </summary>
        public double EjeFluCriSpe
        {
            get { return ejeFluCriSpe; }
            set { ejeFluCriSpe = value; }
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
