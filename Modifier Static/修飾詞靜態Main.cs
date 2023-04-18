/*#### static
- 應用
    - 靜態字段
		- 靜態字段只能通過類來訪問, 不能通過成員訪問
		- 靜態字段是屬於整個類的, 不是哪個成員私有的
		    - 靜態字段是存儲於靜態儲存區中的, 被所有的Test對象所共享, 不是哪一個成員的
	- 靜態函數
		- 靜態函數只能使用靜態數據
        - we.靜態函數也是整個類所有, 不能被哪個成員調用
	- 靜態類
		- 靜態類裡面只能包含靜態成員
- 使⽤static修饰的类为静态类，静态类所有成员都必须是静态的，不能与abstract、sealed⼀起使⽤
- static可以修饰⽅法、字段、属性或事件，始终通过类名⽽不是实例名称访问静态成员，静态字段只有⼀个副本
- 静态类不能被实例化. 也不需要, 因為可以直接用類調用
- 無法繼承
- 用途: 一般數據只存一份兒的放到靜態類中
 */
namespace Modifier_Static
{
    internal class 修飾詞靜態Main
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.hp = 100;
            Test t2 = new Test();
            t2.hp = 200;
            //t1, t2是共享靜態成員count的, 但hp不是共享的
                //t1有自己的hp, t2也有自己的hp
            Test.count = 1;
            Test.count = 2;
            Console.WriteLine(Test.count); //Output: 2
            Test.Move(); //we.靜態函數也是整個類所有, 不能被哪個成員調用
        }
    }
}