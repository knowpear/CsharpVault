//#### 結構體內的函數
/*
当我们在结构体中定义⼀个函数的时候，这个函数就可以通过结构体声明的变量来调⽤，
这个函数可以带有参数，那么调⽤的时候必须传递参数，
这个函数，可以使⽤结构体中的属性
*/
namespace struct_funtion
{
    internal class Program
    {
        //傳統定義方法
        struct Position
        {
            public double x;
            public double y;
            public double z;
        }
        static void printPosition(Position p)
        {
            p.x = 0;
            p.y = 1;
            p.z = 2;
            Console.WriteLine(p.x + ", " + p.y + ", "+ p.z);
        }

        //結構體函數定義方法
        struct newPosition
        {
            public double a;
            public double b;
            public double c;
            public void printNewPosition() //這裡不寫static, 可以沒有參數, 直接使用struct內的參數和屬性
            {
                Console.WriteLine(a + ", "+  b + ", " + c);
            }
        }

        struct Name
        {
            public string firstName;
            public string lastName;
            public string printFullname()
            {
                //Console.WriteLine("全名是: " + lastName + firstName); we.寫法
                return lastName + " " + firstName;
            }
        }

        static void Main(string[] args)
        {
        //傳統調用方法
            Position p1;
            p1.x = 0;
            p1.y = 1;
            p1.z = 2; //這裡實參Position p1的賦值必須和上面函數的形參Position p(即Position結構體)的數量類型完全一致, 下面才能被調用
            printPosition(p1);

        //結構體函數調用方法
            newPosition p2; //這裡實參定義和賦值的類型和數量同樣要和結構體內的一致
            p2.a = 1;
            p2.b = 2;
            p2.c = 3;
            p2.printNewPosition();
            //這個函數必須通過一個變量來調用
            //哪個變量調用的, 就是訪問哪個變量的位置信息 
            //we.這裡先行p2.就相當於傳值了. 
            //這個函數是不需要傳遞參數的, 跟著變量走

            Name zhangsan;
            zhangsan.firstName = "三";
            zhangsan.lastName = "張";
            Console.WriteLine("全名是: " + zhangsan.printFullname());

            Name StevenJobs;
            StevenJobs.firstName = "Steven";
            StevenJobs.lastName = "Jobs";
            Console.WriteLine("全名是: " + StevenJobs.printFullname());
        }
    }
}