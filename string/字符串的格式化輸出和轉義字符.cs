//字符串的格式化輸出
int a = 1;
int b = 2;
Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
//Result: 1 + 2 = 3
Console.WriteLine("計算{0} + {0} = {2}嗎?", a, b, a + b);
//Result: 計算1 + 1 = 2嗎?

//轉義字符
/*
- `\n`換行
- `\t`製表符
- @的作用
	- 取消轉義字符\作用
	- 讓字符串可以多行輸出
		- 只需要前後有引號
		- 若在多行內再要輸出引號", 則寫兩個個引號""
*/
Console.WriteLine(@"c:\a\b\c");
//輸出結果c:\a\b\c
Console.WriteLine(@"www.sikiedu.com\nsiki");
//輸出結果www.sikiedu.com\nsiki
Console.WriteLine(@"www.sikiedu.com""
a
b
c
\nsiki");
//@還可以讓字符串可以跨越多行
//若裡面還需要引號, 則寫兩個
/*輸出結果
www.sikiedu.com"
a
b
c
\nsiki
*/