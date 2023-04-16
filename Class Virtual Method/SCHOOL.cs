using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Virtual_Method
{
    class SCHOOL
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public SCHOOL(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Meeting() //一般方法
        {
            Console.WriteLine("SCHOOL meeting");
        }
    }
}
