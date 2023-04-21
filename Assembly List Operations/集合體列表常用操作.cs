using System.Collections.Generic;

namespace Assembly_List_Operations
{
    internal class 集合體列表常用操作
    {
        //自定義一個顯示列表方法
        static void showlist(List<int> list) //we.?這裡不能省略static
        {
            foreach (int temp in list)
            {
                Console.Write(temp + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //#### 增, 刪, 改, 查, 排, 打
            List<int> list = new List<int>() { 3, 6 , 9, 12, 15, 3};
            //1. 插入元素
            list.Insert(2, 66); //在index2下標位置插入item66
            
            //2. 刪除元素
            //list.Remove(12); //刪除元素12
            list.RemoveAt(4); //刪除下標為4的元素

            showlist(list); //調用打印列表函數

            //3.修改數據
            list[3] = 10;

            //4. 查詢數據
            Console.WriteLine("該數據索引位置是: " + list.IndexOf(6)); //從前往後查詢首個匹配到的元素6所在下標, 若不存在, 返回-1
            Console.WriteLine("該數據索引位置是: " + list.LastIndexOf(6)); //從後往前查詢首個匹配到的元素6所在下標, 若不存在, 返回-1
            
            //5. 排序
            list.Sort(); //默認從小到大排序

            //6.打印信息
            Console.WriteLine(list); //Output: System.Collections.Generic.List`1[System.Int32]
            showlist(list);
        }
    }
}