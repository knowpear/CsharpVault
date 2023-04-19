using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Indexer
{
    internal class Test2
    {
        private string[] name = new string[3] { "zhang1", "zhang2", "zhang3"};
        public string this[int index]
        {
            get
            { 
                return name[index];
            }
            set
            {
                name[index] = value;
            }
            //we.這裡可否理解成傳入的隱藏值有兩個, get的是index, set的是value
        }
    }
}
