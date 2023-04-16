/*
#### Virtual Method虛方法
- 把⼀个基类函数声明为virtual,就可以在任何派⽣类中重写该函数
- we.子類和父類有同名方法, 子類標記虛方法, 即可在子類中重寫該方法
- we.應用場景
	- 當用父類聲明方法, 用子類進行賦值實例化時
	- 此時調用該方法, 優先查找子類中的該方法的虛方法
- 我们在⼦类⾥⾯重写虚函数之后，不管在哪⾥调⽤都是调⽤重写之后的⽅法
```C#
public virtual string VirtualMethod()
{
	return "Method is called in base class";
}
```
- 在派⽣类中重写另外⼀个函数时，要使⽤override关键字显⽰声明
```C#
public override string VirtualMethod()
{
	return "Method is called in derivedclass.";
}
```
 */
namespace Class_Virtual_Method
{
    class 虛函數加父子同時構造Main
    {
        static void Main(string[] args)
        {
            // Create a new school object
            SCHOOL mySchool = new SCHOOL("John", 40);
            
            Console.WriteLine("校長名字{0} 年齡{1}",mySchool.Name, mySchool.Age);
            mySchool.Meeting(); // Output: SCHOOL meeting

            // Create a new grade object
            GRADE myGrade = new GRADE("Jane", 30);
            Console.WriteLine("年級長名字{0} 年齡{1}",myGrade.Name, myGrade.Age);
            myGrade.Meeting(); // Output: GRADE meeting

            //創建一個雜交實例
            SCHOOL sg;
            sg = new GRADE("zhangsan", 80);
            sg.Meeting(); // Output: SCHOOL meeting
        }
    }
}