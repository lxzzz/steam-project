using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ssj.Model
{
    class Material
    {

        string materialName;
        public string MaterialName
        {
            get { return materialName; }
            set { materialName = value; }
        }

        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


       public  Material(DataRow dr) {//构造函数，构造函数的命名必须和类名完全相同
           MaterialName = dr.ItemArray[1].ToString();//set方法
           Id=(int)dr.ItemArray[0];
       }




    }
}
