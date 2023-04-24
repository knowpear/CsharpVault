/*#### we.泛型類和類的泛型方法的區別
泛型類是在類中定義好全局泛型參數. 需要一個初始化賦值函數
類的泛型方法是在方法中傳遞泛型參數
*/

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