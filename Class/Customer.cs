using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    //顾客类
    class Customer
    {
        public string name;
        public string address;
        private int age;
        public string createTime;

        public Customer()
        {
            Console.WriteLine("我是构造函数");
        }

        //we.帶參數是為了構造時就完成初始化賦值
        public Customer(string name,string address, int age, string createTime)
        {
            //這種方法不能見名知義
            //name = arg1;
            //address = arg2;
            //age = arg3;
            //createTime = arg4;

            //參數名和成員名重名的賦值方法
            this.name = name; 
                //this是一個特殊的類, 就是指當前類
                //this.name指的就是該類的name成員, 等號右邊的name就是該構造函數的參數name, 因為離它最近
            this.address = address;
            this.age = age;
            this.createTime = createTime;
        }

        public void setAge(int temp)
        {
            if (temp < 0) return;
            age = temp;
        }
        public int getAge()
        {
            return age;
        }

        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("创建时间：" + createTime);
        }
    }

    //若用構造體創建顧客, 和類看上去沒什麼不同
    //struct CustomerStruct
    //{
    //    public string name;
    //    public string address;
    //    public int age;
    //    public string createTime;

    //    public void Show()
    //    {
    //        Console.WriteLine("名字：" + name);
    //        Console.WriteLine("地址：" + address);
    //        Console.WriteLine("年龄：" + age);
    //        Console.WriteLine("创建时间：" + createTime);
    //    }
    //}
}