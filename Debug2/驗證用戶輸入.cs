namespace Debug2
{
    internal class 驗證用戶輸入
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数字，每行一个");
            int n1 = 0, n2 = 0;

            while (true)
            {
                try
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                        //we.這裡是逐條進入catch塊驗證
                    n2 = Convert.ToInt32(Console.ReadLine());
                    //當try塊內某一行代碼出現異常後, try塊剩下的代碼就不執行了
                        //這裡若n1, n2任意變量輸入不合法就會跳到循環尾, 再到循環頭
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("你输入的数据，不符合规则,请重新输入");
                }
            }

            Console.WriteLine(n1 + n2);
        }
    }
}