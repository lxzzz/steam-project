using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ssj.Model
{
    class Parameters
    {
        //c#在定义类时,通常要把类中声明的对象封装起来,使得外界不能访问这个属性.
        //代码中如果去掉set部分,则外界只能读取name的值,如果去掉get部分,则只能给name赋值.
        //这样就可以控制外界对私有属性name的访问权限了,这种写法是C#的一个特性.
        //get和set会在相应的时候自动调用,主要是为了隐藏程序内的数据结构时用 
        //get是获取该属性的值,set设置该属性的值.
        //在用set时有一个特殊的变量value,就是设置属性时的值
        int materialID;//外键
        public int MaterialID
        {
            get { return materialID; }
            set { materialID = value; }
        }

        Nullable<Double> tem;
        /// <summary>
        /// 温度
        /// </summary>
        public Nullable<Double> Tem
        {
            get { return tem; }
            set { tem = value; }
        }

        Nullable<Double> pk;
        /// <summary>
        /// 压力:kgf/cm2
        /// </summary>
        public Nullable<Double> Pk
        {
            get { return pk; }
            set { pk = value; }
        }

        Nullable<Double> pm;
        /// <summary>
        /// 压力Mpa(A)
        /// </summary>
        public Nullable<Double> Pm
        {
            get { return pm; }
            set { pm = value; }
        }

        Nullable<Double> wh;
        /// <summary>
        /// H:饱和水比焓
        /// </summary>
        public Nullable<Double> Wh
        {
            get { return wh; }
            set { wh = value; }
        }

        Nullable<Double> ws;
        /// <summary>
        /// S:饱和水比熵
        /// </summary>
        public Nullable<Double> Ws
        {
            get { return ws; }
            set { ws = value; }
        }

        Nullable<Double> wv;
        /// <summary>
        /// V:饱和水比容
        /// </summary>
        public Nullable<Double> Wv
        {
            get { return wv; }
            set { wv = value; }
        }

        Nullable<Double> wcp;
        /// <summary>
        /// Cp:饱和水定压比热
        /// </summary>
        public Nullable<Double> Wcp
        {
            get { return wcp; }
            set { wcp = value; }
        }

        Nullable<Double> wcv;
        /// <summary>
        /// Cv:饱和水定容比热
        /// </summary>
        public Nullable<Double> Wcv
        {
            get { return wcv; }
            set { wcv = value; }
        }

        Nullable<Double> eta;
        /// <summary>
        /// ETA:饱和水的动力粘度
        /// </summary>
        public Nullable<Double> Eta
        {
            get { return eta; }
            set { eta = value; }
        }

        Nullable<Double> sh;
        /// <summary>
        /// H:饱和汽比焓
        /// </summary>
        public Nullable<Double> Sh
        {
            get { return sh; }
            set { sh = value; }
        }

        Nullable<Double> ss;
        /// <summary>
        /// S:饱和汽比熵
        /// </summary>
        public Nullable<Double> Ss
        {
            get { return ss; }
            set { ss = value; }
        }

        Nullable<Double> sv;
        /// <summary>
        /// V:饱和汽比容
        /// </summary>
        public Nullable<Double> Sv
        {
            get { return sv; }
            set { sv = value; }
        }

        Nullable<Double> scp;
        /// <summary>
        /// Cp:饱和汽定压比热
        /// </summary>
        public Nullable<Double> Scp
        {
            get { return scp; }
            set { scp = value; }
        }

        Nullable<Double> scv;
        /// <summary>
        /// Cv:饱和汽定容比热
        /// </summary>
        public Nullable<Double> Scv
        {
            get { return scv; }
            set { scv = value; }
        }

        Nullable<Double> surft;
        /// <summary>
        /// SURFT：饱和水表面张力
        /// </summary>
        public Nullable<Double> Surft
        {
            get { return surft; }
            set { surft = value; }
        }


        public Parameters(DataRow dr)
        {
            //MaterialName = dr.ItemArray[1].ToString();//set方法
            MaterialID = (int)dr.ItemArray[16];


            Tem = Object2Double(dr.ItemArray[1]);
            Pk = Object2Double(dr.ItemArray[2]);
            Pm = Object2Double(dr.ItemArray[3]);
            Wh = Object2Double(dr.ItemArray[4]);
            Ws = Object2Double(dr.ItemArray[5]);
            Wv = Object2Double(dr.ItemArray[6]);
            Wcp = Object2Double(dr.ItemArray[7]);
            Wcv = Object2Double(dr.ItemArray[8]);
            Eta = Object2Double(dr.ItemArray[9]);
            Sh = Object2Double(dr.ItemArray[10]);
            Ss = Object2Double(dr.ItemArray[11]);
            Sv = Object2Double(dr.ItemArray[12]);
            Scp = Object2Double(dr.ItemArray[13]);
            Scv = Object2Double(dr.ItemArray[14]);
            Surft = Object2Double(dr.ItemArray[15]);

        }


        Nullable<Double> Object2Double(Object obj)
        {

            try
            {
                return Double.Parse(obj.ToString());
            }
            catch (Exception e)
            {
                return null;

            }


        }


    }
}


