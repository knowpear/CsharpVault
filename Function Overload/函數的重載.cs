//#### 函數的重載
//函数名相同，参数不同，这个叫做函数的重载(编译器通过不同的参数去识别应该调用哪⼀个函数)
//编译器会根据你传递过来的实参的类型去判定调用哪⼀个函数
namespace Function_Overload
{
    internal class 函數的重載
    {
        static int MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static double MaxValue(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxValue(new int[] { 45, 12, 57, 34, 534, 534, 5323, 324 }));
            Console.WriteLine(MaxValue(new double[] { 45, 12, 57, 34, 534, 534, 5323, 324, 23453.3 }));
        }
    }
}