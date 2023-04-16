using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Virtual_Method
{
    class GRADE : SCHOOL
    {
        public GRADE(string name, int age) : base(name, age) { }
        public override void Meeting()
        {
            Console.WriteLine("GRADE meeting");
        }
    }
}
