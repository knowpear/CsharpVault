/*
#### 抽象類
```C#
abstract class Building
{
	public abstract decimal CalculateHeatingCost();
}
```
- definition
	- C#允许把类和函数声明为 abstract
	- 抽象类可以包含普通函数和抽象函数
	- 只有函數定義, 沒有函數體
	- 抽象函数本⾝也是虚拟的Virtual
	- 类是⼀个模板，那么抽象类就是⼀个不完整的模板
		- 我们不能使⽤不完整的模板去构造对象
	- 抽象类不能实例化(構造對象)
		- 但可以聲明對象
		- 可以使用它的子類構造
- 實現抽象類快捷操作
	- 光標放到類名上
		- RC.Quick Actions and Refactorings...
			- Generate overrides...
				- Pick members to override
- summary
	- 父類抽象類
		- 父類抽象方法
	- 子類正常類
		- 子類重寫父類抽象方法
 */
namespace Class_Abstract
{
    internal class 抽象類Main
    {
        static void Main(string[] args)
        {
            Enemy e = new Boss();
            e.Attack(); //這裡誰構造的就會調用誰的攻擊
        }
    }
}