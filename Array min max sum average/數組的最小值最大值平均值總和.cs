//![lsCsharparrayminmax.png](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/lsCsharparrayminmax.png)
namespace Array_min_max_sum_average
{
    internal class 數組的最小值最大值平均值總和
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 0, 3 , 7, 2 };
            int min = array[0];
            int max = array[0];
            int sum = 0;
            //we寫法
            //foreach (int i in array)
            //{
            //    if (i < min)
            //    {
            //        min = i;
            //    }
            //    else if (i > max)
            //    {
            //        max = i;
            //    }
            //    sum += i;
            //}
            //Teacher寫法
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine(" min: " + min
                + " max: " + max
                + " sum: "+ sum
                + " average: "+ sum/array.Length);
        }
    }
}