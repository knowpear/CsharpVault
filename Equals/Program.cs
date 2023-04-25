namespace Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#### Equals值字符串比較
                //值類型比較的是值, 字符串類型比較的是每個字母
            int a = 12;
            int b = 12;
            Console.WriteLine(a.Equals(b));//Output: True a == b 相當於等號判斷

            string str1 = "siki";
            string str2 = "siki";
            Console.WriteLine(str1.Equals(str2));

            //#### Equals類對象比較
                //默認比較的是引用內存地址
            Student stu1 = new Student(18, "小芳");
            Student stu2 = new Student(18, "小芳");

            //原生Equals
            Console.WriteLine(stu1 == stu2); //Output: False
            //#### 重寫後的Equals
            Console.WriteLine(stu1.Equals(stu2)); //Output: True
        }
    }
}