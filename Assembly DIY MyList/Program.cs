namespace Assembly_DIY_MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#### 使用DIY的Mylist聲明一個集合類
            MyList<int> list = new MyList<int>();


            //#### 調用Add方法
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //#### 調用Capacity屬性
            Console.WriteLine(list.Capacity); //Output: 8 翻倍了

            //#### 查看Count屬性
            Console.WriteLine(list.Count); //Output: 5
        }
    }
}