using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj
{
    public class Size
    {
        double workFluCriOCArea;
        /// <summary>
        /// 工作流体临界过流面积
        /// </summary>
        public double WorkFluCriOCArea
        {
            get { return workFluCriOCArea; }
            set { workFluCriOCArea = value; }
        }
        double nozCriDia;
        /// <summary>
        /// 喷嘴临界直径（dpx）
        /// </summary>
        public double NozCriDia
        {
            get { return nozCriDia; }
            set { nozCriDia = value; }
        }
        double nozLen;
        /// <summary>
        /// 喷嘴喉长（Lpx）
        /// </summary>
        public double NozLen
        {
            get { return nozLen; }
            set { nozLen = value; }
        }
        double nozEntDia;
        /// <summary>
        /// 喷嘴入口直径（dp）
        /// </summary>
        public double NozEntDia
        {
            get { return nozEntDia; }
            set { nozEntDia = value; }
        }
        double nozEntSegLen;
        /// <summary>
        /// 喷嘴入口段长（Lp）
        /// </summary>
        public double NozEntSegLen
        {
            get { return nozEntSegLen; }
            set { nozEntSegLen = value; }
        }
        double workFluOFArea;
        /// <summary>
        /// 工作流体2-2断面过流面积（fp2）
        /// </summary>
        public double WorkFluOFArea
        {
            get { return workFluOFArea; }
            set { workFluOFArea = value; }
        }
        double nozExitDia;
        /// <summary>
        /// 喷嘴出口直径（dp1）
        /// </summary>
        public double NozExitDia
        {
            get { return nozExitDia; }
            set { nozExitDia = value; }
        }
        double nozExitCA;
        /// <summary>
        /// 喷嘴出口锥角（α1）
        /// </summary>
        public double NozExitCA
        {
            get { return nozExitCA; }
            set { nozExitCA = value; }
        }
        double nozExitLen;
        /// <summary>
        /// 喷嘴出口长度（L1）
        /// </summary>
        public double NozExitLen
        {
            get { return nozExitLen; }
            set { nozExitLen = value; }
        }
        double nozDis;
        /// <summary>
        /// 喉嘴距（Lc）
        /// </summary>
        public double NozDis
        {
            get { return nozDis; }
            set { nozDis = value; }
        }
        double bouPly;
        /// <summary>
        /// 伴随射流边界层厚度（b）
        /// </summary>
        public double BouPly
        {
            get { return bouPly; }
            set { bouPly = value; }
        }
        double fh2;
        /// <summary>
        /// 引射流体2-2断面过流面积（fh2）
        /// </summary>
        public double Fh2
        {
            get { return fh2; }
            set { fh2 = value; }
        }
        double f2;
        /// <summary>
        /// 混合流体2-2断面过流面积（f2）
        /// </summary>
        public double F2
        {
            get { return f2; }
            set { f2 = value; }
        }
        double mixTubeEntDia;
        /// <summary>
        /// 混合管进口直径（d2）
        /// </summary>
        public double MixTubeEntDia
        {
            get { return mixTubeEntDia; }
            set { mixTubeEntDia = value; }
        }
        double f3;
        /// <summary>
        /// 混合流体3-3断面过流面积（f3）
        /// </summary>
        public double F3
        {
            get { return f3; }
            set { f3 = value; }
        }
        double mixTubeNozDia;
        /// <summary>
        /// 混合管喉管直径（d3）
        /// </summary>
        public double MixTubeNozDia
        {
            get { return mixTubeNozDia; }
            set { mixTubeNozDia = value; }
        }
        double mixTubeLen;
        /// <summary>
        /// 混合管长度（Lk）
        /// </summary>
        public double MixTubeLen
        {
            get { return mixTubeLen; }
            set { mixTubeLen = value; }
        }
        double difExitCA;
        /// <summary>
        /// 扩散管出口锥角（β1）
        /// </summary>
        public double DifExitCA
        {
            get { return difExitCA; }
            set { difExitCA = value; }
        }
        double difLen;
        /// <summary>
        /// 扩散管长（Ld）
        /// </summary>
        public double DifLen
        {
            get { return difLen; }
            set { difLen = value; }
        }
        double workFluSpe;
        /// <summary>
        /// 工作流体速度（ωp）
        /// </summary>
        public double WorkFluSpe
        {
            get { return workFluSpe; }
            set { workFluSpe = value; }
        }
        double workFluEntArea;
        /// <summary>
        /// 工作流体进口面积（Fp）
        /// </summary>
        public double WorkFluEntArea
        {
            get { return workFluEntArea; }
            set { workFluEntArea = value; }
        }
        double workFluEntDia1;
        /// <summary>
        /// 工作流体进口直径（Φp）
        /// </summary>
        public double WorkFluEntDia1
        {
            get { return workFluEntDia1; }
            set { workFluEntDia1 = value; }
        }
        double workFluEntDia2;
        /// <summary>
        /// 工作流体进口直径（Dp）
        /// </summary>
        public double WorkFluEntDia2
        {
            get { return workFluEntDia2; }
            set { workFluEntDia2 = value; }
        }
        double ejeFluSpe;
        /// <summary>
        /// 引射流体速度（ωh）
        /// </summary>
        public double EjeFluSpe
        {
            get { return ejeFluSpe; }
            set { ejeFluSpe = value; }
        }
        double ejeFluEntArea;
        /// <summary>
        /// 引射流体进口面积（Fh）
        /// </summary>
        public double EjeFluEntArea
        {
            get { return ejeFluEntArea; }
            set { ejeFluEntArea = value; }
        }
        double ejeFluEntDia1;
        /// <summary>
        /// 引射流体进口直径（Φh）
        /// </summary>
        public double EjeFluEntDia1
        {
            get { return ejeFluEntDia1; }
            set { ejeFluEntDia1 = value; }
        }
        double ejeFluEntDia2;
        /// <summary>
        /// 引射流体进口直径（Dh）
        /// </summary>
        public double EjeFluEntDia2
        {
            get { return ejeFluEntDia2; }
            set { ejeFluEntDia2 = value; }
        }
        double mixFluSpe;
        /// <summary>
        /// 混合流体速度（ωc）
        /// </summary>
        public double MixFluSpe
        {
            get { return mixFluSpe; }
            set { mixFluSpe = value; }
        }
        double mixFluExitArea;
        /// <summary>
        /// 混合流体出口面积（Fc）
        /// </summary>
        public double MixFluExitArea
        {
            get { return mixFluExitArea; }
            set { mixFluExitArea = value; }
        }
        double mixFluExitDia1;
        /// <summary>
        /// 混合流体出口直径（Φc）
        /// </summary>
        public double MixFluExitDia1
        {
            get { return mixFluExitDia1; }
            set { mixFluExitDia1 = value; }

        }
        double mixFluExitDia2;
        /// <summary>
        /// 混合流体出口直径（Dc）
        /// </summary>
        public double MixFluExitDia2
        {
            get { return mixFluExitDia2; }
            set { mixFluExitDia2 = value; }
        }
    }
}
