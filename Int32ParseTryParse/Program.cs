namespace Int32ParseTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#### Int32.Parse
            string str = "123"; //若不能轉換, 會拋出異常
            int num = Int32.Parse(str);
            Console.WriteLine("转换成功，整数值为：" + num);


            //#### Int32.TryParse
            string str1 = "+123";
            int num1;
            if (Int32.TryParse(str1, out num1))
            {
                Console.WriteLine("转换成功，整数值为：" + num1);
            }
            else
            {
                Console.WriteLine("转换失败");
            }

            //#### Int32.TryParse處理異常情況
            try
            {
                string str2 = "123abc";
                int num2 = Int32.Parse(str2);
                Console.WriteLine("转换成功，整数值为：" + num2);
            }
            catch (FormatException e)
            {
                Console.WriteLine("转换失败，输入的不是数字");
            }

        }
    }
}