namespace Class_Operator_Overloading_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#### .ToString打印測試
            Program p = new Program();
            Console.WriteLine(p.ToString()); //Output: Class_Operator_Overloading_ToString.Program 默認打印的是成員信息
            Console.WriteLine(p); //Output: 同上, 打印成員默認缺省後面的.ToString

            //#### 成員.ToString相加測試
            Program p1 = new Program();
            Program p2 = new Program();
            //不可以相加的寫法
            //p1.ToString() + p2.ToString();
            //可以相加的寫法
            string str = p1.ToString()+p2.ToString();
            Console.WriteLine(str);

            //#### 打印類中的成員
            Student s = new Student("張三", 18);
            Console.WriteLine(s); //equals to Console.WriteLine(s.ToString());
                //未重載Output: Class_Operator_Overloading_ToString.Student Default類成員信息
                //重載後Output: 張三 18
        }
    }
}