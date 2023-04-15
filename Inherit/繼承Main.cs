namespace Inherit
{
    internal class 繼承Main
    {
        static void Main(string[] args)
        {
            //調用基類BaseClass的成員和函數
            BaseClass b1 = new BaseClass();
            b1.data1 = 10;
            b1.data2 = "strChuan";
            Console.WriteLine(b1.data1 + b1.data2);
            b1.Function1();
            b1.Function2();

            //調用派生類DivedClass1的成員和函數
            DrivedClass1 d1 = new DrivedClass1();
            Console.WriteLine(d1.data3);
            d1.Function1(); //可以調用基類(公共類)中的函數
            d1.FunctionDrivedClass1(); //也可以調用自己獨有的函數

            //調用派生類DivedClass2的成員和函數
            DrivedClass2 d2 = new DrivedClass2();
            Console.WriteLine(d2.data3); //不同類的同名變量不受影響
            d2.FunctionDrivedClass2();
        }
    }
}