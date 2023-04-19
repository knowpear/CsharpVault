using _14_索引器;

namespace Class_Indexer
{
    internal class 索引器Main
    {
        static void Main(string[] args)
        {
            //int[] array = new int[5] { 0,1,2,3,4};
            ////使用數組索引器的兩種方式 1.賦值2.取值
            //array[1] = 100; //方式1.利用索引器賦值
            //Console.WriteLine(array[1]); //方式2.利用索引器取值

            //Test.cs
            Test t = new Test();
            t[9] = 200; //這裡調用類索引器, 調用set方法把200傳入到value
            int temp = t[9]; //we.test 調用get查詢方法並接收返回值
            Console.WriteLine(temp); //Output: 100

            //Test2.cs
            Test2 t2 = new Test2();
            Console.WriteLine(t2[2]); //調用get, get內直接輸出返回值
            t2[2] = "bujiaozhang3"; //調用set
            Console.WriteLine(t2[2]);

            //Week.cs
            Week w = new Week();
            Console.WriteLine(w["Thurs"]);
            //Console.WriteLine(w.GetDay("Sun")); //we.假若GetDay為公有, 同上作用的寫法
        }
    }
}