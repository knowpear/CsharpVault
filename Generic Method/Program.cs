namespace Generic_Method
{
    internal class Program
    {
        //#### 改寫前的普通方法
        //public static int GetSum(int a , int b)
        //{
        //    int result = a + b;
        //    return result;
        //}
        //#### 改寫後的泛型方法
        public static T GetSum<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic result = num1 + num2;
            return (T)result;
        }
        static void Main(string[] args)
        {
            //int c = Program.GetSum(1, 2);
                //方法名在同一類中是不能重名的, 但在不同類中是可以重名的
                //靜態方法在其他類中是需要通過 類型.方法 調用的
            int c = GetSum(1, 2); //同上寫法等同, 因為都是在同一類(Program)中, 所以可以省略類名
            Console.WriteLine(c);

            //#### 調用泛型方法
            Console.WriteLine(GetSum<int>(2, 3));
            Console.WriteLine(GetSum<string>("aa", "bb"));
        }
    }
}