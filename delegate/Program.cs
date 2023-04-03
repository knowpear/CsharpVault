//#### delegate
/*
委托(delegate)是⼀种存储函数引⽤的类型。
委托的定义指定了⼀个返回类型和⼀个参数列表
定义了委托之后，就可以声明该委托类型的变量，接着就可以把⼀个返回类型跟参数列表跟委托
⼀样的函数赋值给这个变量。
委托的使⽤分两步
1. 定义
2. 声明（变量）
委托就是⼀个函数类型，可以把⼀个函数赋值给委托类型。
定义委托的时候，跟函数有点像，只不过没有函数体。
只能赋值-参数和返回值⼀样的函数
we.委託就是將多個同規律函數抽象, 再賦值給一個變量概念, 再選擇這個概念對應的函數, 調用這個簡潔的概念函數 
 */
namespace _delegate;

internal class Program
{
    //示例類型1 有返回值有參數
    static double Multiply(double param1, double param2)//函数体
    {
        return param1 * param2;
    }

    static double Divide(double param1, double param2)
    {
        return param1 / param2;
    }

    delegate double MyDelegate1(double param1, double param2);
    
    //示例類型2 無返回值無參數
    static void Test()
    {
        Console.WriteLine("Test");
    }

    delegate void MyDelegate2();
    
    static void Main(string[] args)
    {
        //老函數方法調用
        //Console.WriteLine(Multiply(2.3, 2));
        //Console.WriteLine(Divide(4.5, 3));

        //委託方法調用示例1
        MyDelegate1 delegate1;

        delegate1 = Multiply;
        Console.WriteLine(delegate1(2, 4)); //Result: 8

        delegate1 = Divide;
        Console.WriteLine(delegate1(4,2)); //Result: 2

        //委託方法調用示例2
        MyDelegate2 delegate2;
        delegate2 = Test;
        delegate2(); //Result: Test
    }
}
