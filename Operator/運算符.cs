//Operator運算符

//基本運算符
int a = 6;
int b = 2;
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

//賦值運算符
//![Csharp賦值運算符.png](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpfuzhiyunsuanfu.png)

//自增自减运算符
//a++; //先赋值再自增
//++a; //先自增再賦值
b = a++; //先賦值再+1
Console.WriteLine("a的值是{0}, b的值是{1}", a, b); //Result: a 的值是 7, b 的值是 6

b = ++a; //先+1再賦值
Console.WriteLine("a的值是{0}, b的值是{1}", a, b); //Result: a 的值是 8, b 的值是 8

Console.WriteLine(a++); //先賦值再+1 //Result: a 的值是 8

Console.WriteLine(a); //Result: a 的值是 9

Console.WriteLine(--a); //先+1再賦值 //Result: a 的值是 8

Console.WriteLine(a--); //Result: a 的值是 8

Console.WriteLine(a); //Result: a 的值是 7

//比較運算符
bool c = true; //是的 真的 满足条件 1
bool d = false; //不是 假的 不满足条件 0
Console.WriteLine("c true的值是{0} ; d false的值是{1}" , Convert.ToInt32(c), Convert.ToInt32(d));

//關係運算符
/*
- `==` 判断左边是否等于右边
- `>` 判断左边是否大于右边
- `<` 判断左边是否小右边
- `>=` 判断左边是否大于或等于右边
- `<=` 判断左边是否小于或等于右边
- `!=` 判断左边是否不等于右边
*/

//邏輯運算符
/*
- `&&`邏輯與
    - 如果两个操作数都非零,则条件为真.
- `||`邏輯或
    - 如果两个操作数中有任意一个非零,则条件为真.
- `!`邏輯非
    - 用来逆转操作数的逻辑状态.如果条件为真则逻辑非运算符将使其为假.
*/

//運算符的優先級
//- 比較運算符 > 邏輯運算符
//[Csharp運算符的優先級](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharpyunsuanfudeyouxianji.png)