/*
### Variables
#### 数据类型
- int
- double
- char
- string
- [C#数据类型](http://c.biancheng.net/csharp/data-type.html)

#### 命名規則
- 只能是數字, 字母, 下劃線
- 不能以數字開頭
- 不能佔用保留字
- 驼峰命名法 (Cameli 命名法)
- Pascal 命名规范

```C#
int age;// int 變量類型, age變量名
age = 10; //賦值, 往容器裡放東西
int age2 = 12; //聲明加賦值
int age3 = 10, age4 = 12; //同類型簡潔寫法
```
- [浅谈char字符类型和string字符串类型_char是字符串还是字符_Lu-Yu的博客-CSDN博客](https://blog.csdn.net/Yu1543376365/article/details/79176606)

#### Variables syntax
- 先聲明, 再使用
	- 類型必須相同
- 先賦值, 再讀取(先賦值再比較)
	- 小容器可以賦值到大容器; 反之不可
- 再次賦值, 數據覆蓋
- char字符類型可以當做int整數類型使用
- 數字+字符串相當於組拼, 不做數學運算, 然後都變成字符串
- String類型變量的初始化`String 變量 = "";`

#### 變量的作用域
- 變量只在自己方法內(花括號為界)生效
- 子作用域可以訪問父作用域中的變量
- 父作用域不能訪問子作用域中的變量
- 作用域結束後, 該域內定義的變量會被清空銷毀
- 同一个作用域内不能有重名變量, 不同作用域內可以有同名變量
	- for循環內的變量也是局部變量. do while相反?
- ![Csharp作用域we.從一而終原則](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpbianlianzuoyongyujieshi.png)

#### 數據類型轉換
- 顯式轉換
	- 也叫做强制类型转换，强塞
	- 把⼀个大盒子裡面的东西放进小盒子的时候，编译器不确定能不能放得下，所以默认是不允许放的，除非你告诉他 我非要放。
	- 编译器只检查容器大小，不检查容器内的具体数值大小，为什么？因为变量裡面的东西是变化的，变量裡面的值需要在程序运⾏的时候才确定下来
- 隱式轉換
	- 当小盒子放入大盒子的时候，肯定可以放得下，所有会⾃动进⾏转换。不需要做多余操作
	- [安全轉換](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpanquanzhuanhuan.png)
	- [轉換命令](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpzhuanhuanmingling.png)
- 如何把⼀个数字转成数字字符串
- 1. Convert.ToString()
- 2. number + "";
- 強制類型轉換
	- e.g.`(char)Variable`

#### ASCII
- [ASCII图片_百度百科](https://baike.baidu.com/pic/ASCII/309296/1/e850352ac65c103880a07b53bc119313b17e8941?fr=lemma&ct=single#aid=1&pic=e850352ac65c103880a07b53bc119313b17e8941)
*/

//#### 查詢ASCII
char n;
int nASCII;
Console.WriteLine("請輸入一個字符");
n = Convert.ToChar(Console.ReadLine()); //Console.ReadLine是string類型, 這裡轉換為char
nASCII = (int)n; //再把char強制轉換為int, 以獲得ASCII碼
//nASCII = Convert.ToInt32(n); 此寫法等價
Console.WriteLine("{0}的ASCII是: {1}", n, nASCII);

//#### 字符變ASCII碼 方法即char強塞給int 或 char強制轉換為int
char a = 'c';
int b = a; //char字符類型也是整數形式存儲的, 字符類型可以當做整數類型使用, 見ASCII. 所以左右類型一致(整數型), 才可以賦值
//int b= Convert.ToInt32(a); 等同於上句
Console.WriteLine(a);
Console.WriteLine(b);

//ASCII碼變字符 方法即int強塞給char 或 int強制轉換為char
int d = 97;
//char e = d; 報錯, 大容器int 不能賦值給小容器char
char e = (char)d; //強塞, 強制類型轉換
//char e = Convert.ToChar(d); 等同於上句
Console.WriteLine(e);

//#### 常量
//習慣上用大寫
const double PI = 3.1415926;
Console.WriteLine(PI);