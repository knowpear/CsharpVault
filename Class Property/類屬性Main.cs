﻿namespace Class_Property
{
    internal class 類屬性Main
    {
        static void Main(string[] args)
        {
            //屬性方法調用流程
            Customer屬性方法 zhangsan = new Customer屬性方法();
            Console.WriteLine(zhangsan.Age); //Result: 0 即默認值
            zhangsan.Age = 81; //使用時當做成員使用, 但是實際是調用了系統類屬性中的set函數
            Console.WriteLine(zhangsan.Age); //Result: 81調用了系統類屬性中的get

            Console.WriteLine(zhangsan.CreatTime); //Result: null 即默認值
            zhangsan.CreatTime = "202304";
            Console.WriteLine(zhangsan.CreatTime); //Result: 202304

            //屬性方法簡寫調用
            Customer屬性方法簡寫 zhaoliu = new Customer屬性方法簡寫();
            zhaoliu.Name = "趙六";
            Console.WriteLine(zhaoliu.Name); //Result: 趙六

            zhaoliu.Address = "家裡蹲";
            Console.WriteLine(zhaoliu.Address); //Result: 家裡蹲

            zhaoliu.show(); //Result: 趙六 /n/r 家裡蹲
        }
    }
}