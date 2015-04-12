using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssj
{
    public static class DataShare
    {
        static SysPar sysPar;

        public static SysPar SysPar
        {
            get { return DataShare.sysPar; }
            set { DataShare.sysPar = value; }
        }

        static WorkPar workPar;

        public static WorkPar WorkPar
        {
            get { return DataShare.workPar; }
            set { DataShare.workPar = value; }
        }

        static EjePar ejePar;

        public static EjePar EjePar
        {
            get { return DataShare.ejePar; }
            set { DataShare.ejePar = value; }
        }

        static MixPar mixPar;

        public static MixPar MixPar
        {
            get { return DataShare.mixPar; }
            set { DataShare.mixPar = value; }
        }

    }
}
