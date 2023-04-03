//[循環方法fnwe理解](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpfuntionrecursionfnxunhuanweunstand.png)
//[遞歸函數調用test死循環演示](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpfunctionresursiontestsixunhuan.png)
//[遞歸函數fn理解](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpfuntionrecursionfnunderstand.png)
namespace Funciton_Recursion
{
    class 遞歸函數調用
    {

        static void Test()
        {
            Console.WriteLine("test1");
            Test();
            Console.WriteLine("test2");
        }

        static int F(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            if (n == 1)
            {
                return 3;
            }

            int res = F(n - 1) + F(n - 2);
            return res;
        }

        static void Main(string[] args)
        {
            //循環方法
            //fn = fn1 + fn2  f0=2 f1=3
            //int n1 = 3;//f1
            //int n2 = 2;//f0
            //int n = 0;
            //for(int i = 2; i < 41; i++)//2~40
            //{
            //    n = n1 + n2;
            //    n2 = n1;
            //    n1 = n;
            //}
            //Console.WriteLine(n);

            //Test();
            //遞歸函數方法
            Console.WriteLine(F(40));
        }
    }
}
