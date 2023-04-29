using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_finally
{
    internal class Sample
    {
        public static void sample1()
        {
            int[] array = new int[4] { 0, 1, 2, 3 };
            try
            {
                int temp = array[5];
            }
            catch (IndexOutOfRangeException e) //遇到這第一個異常就會返回
            {
                //出現這個異常的時候怎麼處理, 但即便異常程序也不會跳出
                Console.WriteLine(e.Message); //系統寫法
                //Console.WriteLine("數組下標越界"); //手工寫法
            }
            catch (FieldAccessException e)
            {
                Console.WriteLine("數組FieldAccessException");
            }
            catch
            {
                //catch後不加括號表示捕捉任意類型的異常
                Console.WriteLine("捕捉任意類型異常");
            }
            finally
            {
                Console.WriteLine("不管是否出現異常, 都會執行");
            }
            Console.WriteLine("驗證輸出與否");
        }

        public static void sample2()
        {
            Console.WriteLine("请输入两个数字，每行一个");
            int n1 = 0, n2 = 0;

            while (true)
            {
                try
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    //we.這裡是逐條進入catch塊驗證
                    n2 = Convert.ToInt32(Console.ReadLine());
                    //當try塊內某一行代碼出現異常後, try塊剩下的代碼就不執行了
                    //這裡若n1, n2任意變量輸入不合法就會跳到循環尾, 再到循環頭
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("你输入的数据，不符合规则,请重新输入");
                }
            }

            Console.WriteLine(n1 + n2);
        }

        public static void sample3()
        {
            while (true)
            {
                try
                {
                    // 這裡是可能會產生錯誤的程式碼區塊
                    Console.Write("請輸入一個整數: ");
                    int x = int.Parse(Console.ReadLine());
                    int y = 10 / x;
                    Console.WriteLine("10 / {0} = {1}", x, y);
                    break;
                }
                catch (FormatException)
                {
                    // 如果使用者輸入的不是整數，則會發生 FormatException 錯誤
                    Console.WriteLine("請輸入整數！");
                }
                catch (DivideByZeroException)
                {
                    // 如果使用者輸入的是 0，會發生 DivideByZeroException 錯誤
                    Console.WriteLine("不能輸入 0！");
                }
                catch
                {
                    Console.WriteLine("啥啊?"); //實測必須在放在所有catch語句最後
                }
                finally
                {
                    // 無論 try 區塊中的程式碼是否發生錯誤，都會執行這個區塊
                    Console.WriteLine("無論如何！");
                }
            }
        }
    }
}