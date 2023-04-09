using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Property
{
    internal class Customer屬性方法
    {
        private string name;
        private string address;
        private int age;
        private string createTime;

        //類屬性初始化get和set方法
        public int Age //當成get方法和set方法的簡寫
        {
            get
            {
                return age;
            }
            set
            {
                //Optional code
                //if (value < 0)
                //{
                //    return;
                //}
                age = value; //value是Default, 系統保留關鍵字
            }
        }

        public string CreatTime
        {
            //get和set被稱為訪問器, 默認按照屬性訪問權限即上面的public表示. 也可單獨設置權限
            //private get
            get
            {
                return createTime;
            }
            //get和set也可以二選一. 只有get即只讀. 只有set即只寫.
            set
            {
                createTime = value;
            }
        }
    }
}
