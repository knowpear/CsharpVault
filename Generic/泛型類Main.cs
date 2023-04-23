namespace Generic
{
    internal class 泛型類Main
    {

        static void Main(string[] args)
        {
            //調用a+b.cs
            ClassA<int> sum = new ClassA<int>(12, 24); //這裡必須傳遞兩個參數
            Console.WriteLine(sum.GetSum());
        }
    }
}