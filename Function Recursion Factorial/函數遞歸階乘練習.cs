//#### 求n!  和 求 1!+2!+..n!
//- [we階乘循環思路](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpjiechengxunhuanwesilu.png)

namespace Function_Recursion_Factorial
{
    class 函數遞歸階乘練習
    {
        static int F(int n) //求n!
        {
            if (n == 1)
            {
                return 1;
            }
            int result = n * F(n - 1);
            return result;
        }

        static void Main(string[] args)
        {
            //10! = 10*9 ...   1

            //int result = 1;
            //for(int i = 1; i < 11; i++)
            //{
            //    result = result * i;
            //}
            //Console.WriteLine(result);

            //10!
            // f(n)=n*f(n-1)
            // 10! = 10*9!
            // f(1)=1 
            //Console.WriteLine(F(10));

            // 1+2!+3!+...+10!

            //int total = 0;
            //for(int i = 1; i < 11; i++)
            //{
            //    int temp = 1;
            //    for (int j = 1; j < i + 1; j ++) {
            //        temp = temp * j;
            //    }

            //    // i!
            //    total = total + temp;
            //}
            //Console.WriteLine(total);

            //1+2!+3!+...+10!
            //f(n)=1+2!+3!+...+n!
            //f(n)=f(n-1) + n!
            //f1(n)=n!
            //f2(n)=f2(n-1) + n!
            Console.WriteLine(F2(10));
        }
        //求 1!+2!+..n!
        static int F1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int result = n * F1(n - 1);
            return result;
        }
        static int F2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return F2(n - 1) + F1(n);
        }
    }
}