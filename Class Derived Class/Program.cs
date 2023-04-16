/* #### Derived Class派生類的構造函數
- 1. 在⼦类中调⽤⽗类的默认构造函数（⽆参）（会先调⽤⽗类的，然后是⼦类的）
	- 在这⾥ ：base()可以直接不写，因为默认会调⽤⽗类中的默认构造函数
```C#
public class MyDerivedClass:BaseClass
{
	public MyDerivedClass(): base()
	{
		//do something
	}
}
```
- 2. 调⽤有参数的构造函数
	- //在子類裡調用父類裡的構造函數
	- //這裡即使省略base()也會先調用父類函數
	- //在調用子類時, 它必然會調用某個父類構造函數(匹配的), 當不指定時, 就會調用父類裡無參的
```C#
public class MyDerivedClass:BaseClass
{
	public MyDerivedClass(string name) : base(name) 
	{
		//do something
	}
}
```
 */
namespace Class_Derived_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//#### 1.無參測試
            //DrivedClass drivedClass = new DrivedClass();
            //Output: This is BaseClass
                    //This is Drived Class
            //#### 2.有參測試
			DrivedClass drivedClass2 = new DrivedClass(100,10, 80);
				//Output: BaseClass hp, speed構造執行了 CRLF This is Drived Class
				//它首先調用父類裡無參的構造函數, 然後調用子類裡的有參構造函數
					//就不會再調用父類有參的構造函數了
        }
    }
}