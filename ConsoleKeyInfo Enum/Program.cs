namespace ConsoleKeyInfo_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#### 獲取用戶輸入文本
            string input = Console.ReadLine();
            Console.WriteLine("輸入的文本是: " + input);

            //#### 獲取用戶輸入文本並轉換為數字
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("輸入的數字是: " + input2);


            //#### 獲取並打印用戶按鍵
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            keyInfo = Console.ReadKey();
            //ConsoleKeyInfo keyInfo = Console.ReadKey(); //連寫方法
            Console.WriteLine(keyInfo.KeyChar);

            //#### 循環判斷用戶按鍵
            ConsoleKeyInfo keyInfo2; //新建另一個結構體實例, 這個要定義在外面, 否則while無條件
            do
            {
                keyInfo2 = Console.ReadKey();
                if (keyInfo2.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("用户按下了 Enter 键");
                    break;
                }else if((keyInfo2.Modifiers & ConsoleModifiers.Control) != 0) //這裡可替換為Alt, Shift
                {
                    Console.WriteLine("用户按下了 Ctrl + " + keyInfo2.Key.ToString());
                    //Console.WriteLine("用户按下了 Ctrl + " + keyInfo2.Key);  //省略ToString()寫法
                }
            } while (keyInfo2.Key != ConsoleKey.Escape); //當不等於Esc時執行, 即當等於它時退出

            //#### 按鍵退出官方簡潔寫法
            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey(false).Key != ConsoleKey.Enter) { }
            //ReadKey(false) to display the pressed key. Default true: to not display
            Console.WriteLine("已經按下Enter, 退出!");

            //#### 按鍵退出另一種寫法
            //while (true)
            //{
            //    ConsoleKeyInfo quit = Console.ReadKey(false);
            //    if (quit.Key == ConsoleKey.Enter)
            //    {
            //        break;
            //    }
            //}
        }
    }
}