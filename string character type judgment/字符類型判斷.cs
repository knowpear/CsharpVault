namespace string_character_type_judgment
{
    internal class 字符類型判斷
    {
        static void Main(string[] args)
        {
            //#### basic判斷
            Console.WriteLine("輸入任意字符以進行判斷: ");
            char input = Convert.ToChar(Console.ReadLine());
            //數字的範圍
            if (input > '0' && input < '9')
            {
                int inputnum = input - '0';
                Console.WriteLine("{0}是數字{1}", input, inputnum);
            }
            //字母的範圍
            else if ((input >= 'a' && input <= 'z') || (input >= 'A' && input <= 'Z'))
            {
                Console.WriteLine("{0}是字母", input);
            }

            //#### 判斷合法C#標識符
            // 判断 数字 字母 _
            // 数字开头
            Console.WriteLine("判斷合法C#標識符, 請輸入變量名");
            string str = Console.ReadLine();
            bool isRight = true;
            if (str[0] >= '0' && str[0] <= '9') //先判斷首字符
            {
                isRight = false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if ((str[i] < '0' || str[i] > '9') && (str[i] < 'a' || str[i] > 'z') && (str[i] < 'A' || str[i] > 'Z') && (str[i] != '_'))
                    {
                        isRight = false;
                        break;
                    }
                }
            }
            if (!isRight)
            {
                Console.WriteLine("不是合法标识符");
            }
            else
            {
                Console.WriteLine("是合法标识符");
            }
        }
    }
}