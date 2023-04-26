/*#### 構造函數
- 構造函數是沒有返回值, 函數名和類名保持一致的函數
- 類必須有構造函數
	- 未添加時, 系統幫我們添加無參構造函數(當我們創建實例時)
		- 每次創建實例都會調用一次構造函數
	- 當我們定義了一個構造函數時, 系統默認添加的無參構造函數就沒有了
- 構造函數可以有多個
	- 調用時會選擇參數匹配的構造函數
- 構造函數可以重載

```C#
public class MyClass
{ 
	public MyClass()
	{
	这个构造函数的函数体
	}
}
```
*/

namespace Class_Constructor
{
    internal class 類的構造函數Main
    {
        //MyClass類
        internal class MyClass
        {
            private int myInt;
            private string myString;
            //無參構造函數
            public MyClass()
            {
                Console.WriteLine("調用了無參構造函數");
            }

            //int參數構造函數
            public MyClass(int intValue)
            {
                myInt = intValue;
                Console.WriteLine("調用了int參數構造函數，myInt的值为：" + myInt);
            }
            
            //str參數構造函數
            public MyClass(string stringValue)
            {
                myString = stringValue;
                Console.WriteLine("調用了str參數構造函數, myString的值為: " + myString);
            }

            //成員方法
            public void MyMethod()
            {
                Console.WriteLine("MyMethod被调用，myInt的值为：" + myInt);
            }
        }
        //Main函數
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass();
            MyClass obj2 = new MyClass(123);
            MyClass obj3 = new MyClass("字串");

            obj1.MyMethod();
        }
    }
}
/*
我们定义了一个名为MyClass的类，它有一个私有成员变量myInt和一个公共构造函数。
构造函数接受一个int类型的参数，并将其赋值给myInt变量。
在构造函数中，我们还输出了一个消息，表示对象已创建。
该类还有一个名为MyMethod的公共成员方法，用于输出myInt变量的值。
*/