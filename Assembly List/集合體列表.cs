using System.Collections.Generic;

namespace Assembly_List
{
    internal class 集合體列表
    {
        static void Main(string[] args)
        {
            //1.初始化列表
            List<string> list2 = new List<string>();
            List<int> list = new List<int>() { 0, 3, 5, 6}; //也可以給初始數據(減少性能損耗), 不限數量, 可增可減
            //2.添加數據
            list.Add(8);
            list.Add(9);
            //3.調用數據
            Console.WriteLine("列表下標5的數據是" + list[5]); //Output: 9 類似數組

            //4.修改數據
            list[0] = 66;

            //5.遍歷列表
            //列表裡默認有個計數器count, count是屬性, 不是函數方法
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach (int temp in list)
            {
                Console.WriteLine(temp);
            }

            //6.打印信息
            Console.WriteLine(list.Count + ": " + list.Capacity); //Output: 6:8
            //list.Add(8);
            //list.Add(9);
            //list.Add(8);
            //list.Add(9);
            //Console.WriteLine(list.Count + ": " + list.Capacity); //Output: 10:16 翻倍了
        }
    }
}