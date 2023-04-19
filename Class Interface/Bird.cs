using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Interface
{
    internal class Bird : Ifly //把接口安裝到小鳥身上
    {
        public void Fly()
        {
            Console.WriteLine("Fly小鳥在空中飛");
        }

        public void FlyAttack()
        {
            Console.WriteLine("FlyAttack小鳥在空中攻擊");
        }
    }
}
