using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWrite
{
    internal class stringFormat
    {
        public void stringFormatPrint()
        {
            //## 字符串的格式化輸出
            int a = 1;
            int b = 2;
            Console.WriteLine("計算{0} + {1} = {2}", a, b, a + b);
            //Result: 計算1 + 1 = 2嗎?
            Console.WriteLine($"計算{a} + {b} 等於 {a + b}");

            //## @的用法
                //取代轉義字符
            //### e.g1
            Console.WriteLine(@"c:\a\b\c");
            //輸出結果c:\a\b\c
            
            //### e.g.2
            Console.WriteLine(@"www.sikiedu.com\nsiki");
            //輸出結果www.sikiedu.com\nsiki
            
            //### e.g.3
            //@還可以讓字符串可以跨越多行
            //若裡面還需要引號, 則寫兩個
            Console.WriteLine(@"www.sikiedu.com""
a
b
c
\nsiki");
            /*輸出結果
            www.sikiedu.com"
            a
            b
            c
            \nsiki
            */
        }
    }
}