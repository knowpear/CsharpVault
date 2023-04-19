using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Interface
{
    internal class Plane : Ifly //把接口安裝到飛機身上
    {
        public void Fly()
        {
            Console.WriteLine("Fly飛機在空中飛");
        }

        public void FlyAttack()
        {
            Console.WriteLine("FlyAttack飛機在空中攻擊");
        }
    }
}
