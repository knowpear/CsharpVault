namespace Class_Operator_Overloading
{
    internal class 運算符重載Main
    {
        static void Main(string[] args)
        {
            //+ - * / ==
            //函数重载

            Student s1 = new Student(20, "张三", 12803); //`==`本來比較的是兩個值的引用
            Student s2 = new Student(20, "张三", 12903);

            Student s3 = s1;

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 != s2);
            Console.WriteLine(s1 == s3);
        }
    }
}