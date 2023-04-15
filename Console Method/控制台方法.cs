namespace Console_Method
{
    internal class 控制台方法
    {
        static void Main(string[] args)
        {
            //#### 獲取用戶輸入
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入的數字是: " + input);

            //#### 獲取用戶按鍵和對應ASCII we.
            while (true)
            {
                System.ConsoleKey a = Console.ReadKey().Key; //System.ConsoleKey是ReadKey()的返回值類型
                Console.WriteLine("ConsoleKey 輸入值: " + a);

                int b = Convert.ToInt32(a);
                Console.WriteLine("ASCII 輸入值: " + b);

                char c = Convert.ToChar(a);
                Console.WriteLine("字符 輸入值: " + c);

                //we按鍵退出寫法
                Console.WriteLine("Press <Enter> to exit... ");
                if (a == ConsoleKey.Enter)
                {
                    Console.WriteLine("已經按下Enter, 第一次退出");
                    break;
                }
            }

            //#### 按鍵退出官方簡潔寫法
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey(false).Key != ConsoleKey.Enter) { }
            //ReadKey(false) to display the pressed key. Default true: to not display
            Console.WriteLine("已經按下Enter, 第二次退出");

            //另一種寫法
            //while (true)
            //{
            //    ConsoleKeyInfo c = Console.ReadKey(false);
            //    if (c.Key == ConsoleKey.Enter)
            //    {
            //        break;
            //    }
            //}
        }
    }
}