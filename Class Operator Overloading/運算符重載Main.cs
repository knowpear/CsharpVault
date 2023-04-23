namespace Class_Operator_Overloading
{
    internal class 運算符重載Main
    {
        static void Main(string[] args)
        {
            //+ - * / ==
            //函数重载

            Student s1 = new Student(20, "张三", 12803); //`==`本來比較的是兩個值的引用
            Student s2 = new Student(20, "张三", 12803);

            Student s3 = s1; //we.傳遞的是地址

            Console.WriteLine(s1 == s2);
                //無運算符重載Output: False 值雖相同, 但地址不同, 類成員間默認比較的是地址
                //有運算符重載Output: True 重載內寫明了比較的是成員的值了
            Console.WriteLine(s1 != s2);
            Console.WriteLine(s1 == s3); //無論有無重載Output: TRUE. //we.傳遞的是地址, 不受影響
        }
    }
}