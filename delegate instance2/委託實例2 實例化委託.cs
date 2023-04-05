//#### 委託實例2 Resource: [C# 委托（Delegate）_w3cschool](https://www.w3cschool.cn/csharp/csharp-delegate.html)

delegate int NumberChanger(int n);
namespace DelegateAppl
{
    internal class TestDelegate
    {
        static int num = 10; //注意這裡是全局變量
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            // 创建委托实例
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            // 使用委托对象调用方法
            //Console.WriteLine(num); Result: 10
            nc1(25);
            //Console.WriteLine(num); Result: 35
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            //Console.WriteLine(num); Result: 175
            Console.WriteLine("Value of Num: {0}", getNum());

            Console.WriteLine("Value of Num: {0}", nc1(25));
            //Console.WriteLine(num); Result: 200
            Console.WriteLine("Value of Num: {0}", nc2(5));
            //Console.WriteLine(num); Result: 1000

            Console.ReadKey();
        }
    }
}