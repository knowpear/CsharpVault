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

            //#### 使用索引器: 打印已有元素. 必須配合類中索引器使用
            //索引器set方法測試
            list[0] = 66;
            //索引器get方法測試
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            
            //#### 索引超出異常Throw測試
            //Console.WriteLine(list[99]);
        }
    }
}