/*
### Syntax語法規範
- 一行一條语句，语句的结束加上；
- 代码块 {}
#### annotation注釋
```C#
//單行注釋

/星多行注釋
多行注釋星/

```
#### 項目層級結構

```C#
using System; //引入命名空間
using System.Reflection.Emit;
using System.Threading.Channels;
// See https://aka.ms/new-console-template for more information
namespace name
{
    class Program
    {
        static void Main(string[] args) //這裡是方法
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, \nWorld!");
            Console.WriteLine("Hello, \tWorld!");
        }
    }
}
```

-namespace命名空間.就是對代碼進行分類的
- namespace命名空間的名字和項目名保持一致
- class類的名字和文件名保持一致
- 層級結構:
	-命名空間
        - 定義命名空間
            - 類
                - 方法
- Console其實是類, WriteLine是方法.它們是別人定義的類和方法

#### Top-level statements
- [C console app template changes in .NET 6 + - .NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/core/tutorials/top-level-templates)
    -dotnet6.0新特性, 可省略top - level statements(由系統自動生成)
- When creating program
    - O: it will generate an explicit Program class and Main method instead of top-level statements. (old style)
	-X: it will generate program using top-level statements(new feature, 頂級語句, 即we.簡略模式)

- For.NET 5 and earlier versions
```C#
namespace project_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```
*/