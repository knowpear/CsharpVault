/*
- 函數名
- 參數可有可無
- we.函數體(方法)
- 返回值可有可無
	- O: 需要同類型變量去接收
- Return是終止函數執行的, 即後面代碼無效
	- for循环内有return, 則外面也需要有return, 否則循環內的代碼如果不執行, 那麼這個函數就沒有返回值了
- we.Console.WriteLine(函數);也相當於調用返回值了
 */
namespace 基本函數到參數數組函數
{
    internal class Program
    {
        //無返回值無參數函數
        static void Add0()
        {
            Console.WriteLine("調用無返回值無參數函數");
        }
        
        //有返回值有參數函數
        static int Add1(int a, int b)
        {
            int c = a + b; //這個c ,包括a, b 是局部變量, 儘內部使用, 不與外部通訊
            return c;
        }
        //數組返回值的函數
        static string[] Add1_1(string a, string b)
        {
            string[] array = new string[] { a , b };
            return array;
        }
        //帶數組參數函數
        static int Add2(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }
        //參數數組函數
        static int Add3(params int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }

        static int Add4(string name, params int[] array) //we.混合參數數組
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //調用無返回值無參數函數
            Add0();

            //調用有返回值有參數函數
            int Result1 = Add1(1, 2); //we.接收返回值得同時已經調用了, 即函數已經執行一次了
            Console.WriteLine("調用有返回值有參數函數: " + Result1);

            //調用數組返回值的函數
            string[] Addresult = Add1_1("參數a", "參數b"); //新建對應類型數組用於接收結果
            /*同等分步寫法
            string[] Addresult; //新建接收數組
            Addresult = Add1_1("參數a","參數b"); //調用函數並接收結果
            */
            Console.Write("調用數組返回值的函數: ");
            foreach(string s in Addresult)//遍歷輸出字符串數組結果
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //調用帶數組參數函數
            int[] sum = new int[] { 1, 2, 3, 4, 5 }; //建立數組
            int result = Add2(sum); //調用方法, 傳參, 接收結果
            Console.WriteLine("調用帶數組參數函數: " + result); //輸出結果

            //調用參數數組函數
            int sum3 = Add3(1, 2, 3, 4, 5); //we.可直接寫入任意數量的數組元素
            int sum4 = Add3(sum); //we.或者傳入自定義數組
            Console.WriteLine("調用參數數組函數: " + sum3);
            Console.WriteLine("調用參數數組函數: " + sum4);

            //調用we.混合參數數組函數
            int sum5 = Add4("張三", 1, 2, 3, 4, 5);
            Console.WriteLine("調用參數數組函數: " + sum5);
        }
    }
}