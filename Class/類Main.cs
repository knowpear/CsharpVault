using Class;
using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ////利用类创建对象， c1就是对象名
            //Customer c1 = null ; //= new Customer();
            ////Customer c2;//声明对象
            ////c2 = new Customer();//实例化一个对象

            ////c1.name = "siki";
            ////c1.address = "北京";
            ////c1.age = 20;
            ////c1.createTime = "2021年";

            //c1.name = "www.sikedu.com";

            //c1.Show();

            //Customer c1 = new Customer();
            //Customer c2 = new Customer();
            //c1.name = "张三";
            //c2.name = "李四";
            //c1.Show();
            //c2.Show();

            //Vehicle car1 = new Vehicle();

            //car1.Run();
            //car1.Stop();

            //Vector3 v1 = new Vector3();

            ////v1.z = 12.3f;
            ////v1.x = 2.5f;

            //v1.SetX(-3);
            //v1.SetY(4.5f);
            //v1.SetZ(6.7f);

            //Console.WriteLine(v1.getX());
            //Console.WriteLine(v1.Length());

            //Customer lisi = new Customer();
            ////lisi.age = -10;
            //lisi.setAge(-10);
            //lisi.Show();

            //Customer lisi1 = new Customer();
            //lisi1.Show();
            //Customer lisi2 = new Customer();
            //Customer lisi3 = new Customer();
            Customer zhangsan = new Customer("张三", "三里屯", 20, "2021年");
            zhangsan.Show();

        }
    }
}
