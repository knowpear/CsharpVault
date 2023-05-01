## 類的屬性
- 在C#中，属性是一种用于访问和设置对象成员变量的语法。您可以使用自动属性和手动字段来实现属性。以下是自动属性和手动字段的区别：
    - 自动属性：自动属性是一种简化的属性语法，它使用{get; set;}来自动实现属性的getter和setter方法。在使用自动属性时，编译器会自动为您生成一个私有的字段来存储属性的值。例如：public string Name { get; set; }。
    - 手动字段：手动字段是一种手动实现的字段，您需要手动实现getter和setter方法来访问和设置该字段的值。例如：private string name; public string GetName() { return name; } public void SetName(string value) { name = value; }。
- 因此，自动属性和手动字段是不同的语法和用途，您可以根据需要选择使用哪种语法来实现属性。如果您只需要一个简单的属性来访问和设置成员变量的值，则可以使用自动属性。如果您需要更复杂的逻辑来访问和设置成员变量的值，则可以使用手动字段和自定义getter和setter方法。

- 1.定义属性需要名字和类型
- 2.属性包含两个块, get块和set块
	- 当取得属性的值的时候，就会调⽤属性中的get块，所以get块，类型需要⼀个返回值就是属性的类型
	- 当我们去给属性设置值的时候，就会调用属性中的set块，我们可以在set块中通过value访问到我们设置的值

```C#
public int MyIntProp
{ 
	get{
	//get code
	}
	set{
	//set code
	}
}
```

- 通过属性来访问字段
	- 我们习惯上把字段设置为私有的，这样外界不能修改字段的值，然后我们可以通过定义属性来设置和取得字段中的值
	- 习惯上属性⼤写, 字段⼩写
```C#
private int age;
public int Age
{
    set
    {
        if (value < 0) return;
        age = value;
    }
    get
    {
        return age;
    }
}
```
- 设置属性的只读或者只写
	- 属性可以值只提供⼀个set块或者get块
```C#
private string name;
public string name
{
    get
    {
        return name;
    }
}
```
- 属性的访问修饰符
```C#
public string name
{
    get
    {
        return name;
    }
    private set
    {
        name = value;
    }
}
```
- 自动实现的属性
```C#
public int Age{get;set;}
//编译器会⾃动创建private int age属性
```