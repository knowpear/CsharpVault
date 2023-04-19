using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Indexer
{
    internal class Test
    {
        //定義索引器
        public int this[int index]
        {
            get 
            {
                Console.WriteLine(index);
                return 100;
            } 
            
            set 
            {
                //Console.WriteLine(index);
                //value 系統Default
                Console.WriteLine(value);
            }
            //we.實測這裡的get必須有返回值, set不能有返回值
        }
        
    }
}
