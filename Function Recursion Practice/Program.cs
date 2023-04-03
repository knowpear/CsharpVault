//有关系式1*1+2*2+3*3+...+k*k<2000,编⼀个程序，求出满⾜此关系式的k的最⼤值利⽤递归和循环解决这个问题
namespace Function_Recursion_Practice
{
    class Program
    {
        //f(n)=1 + 2 +..  n
        //f(n)= f(n-1)+n
        //f(1)=1
        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return F(n - 1) + n * n;
        }
        static void Main(string[] args)
        {

            //int k = 1;
            //int result = 0;
            //while (true)
            //{
            //    result += k * k;
            //    if (result >= 2000)
            //    {
            //        break;
            //    }
            //    k++;
            //}
            //Console.WriteLine(k - 1); //試錯值 - 1 才是臨界值

            int i = 1;
            while (true)
            {
                if (F(i) >= 2000) //we.每次都是代入一個i的值, 計算出單次F(i)的結果進行判斷的
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i - 1);
        }
    }
}