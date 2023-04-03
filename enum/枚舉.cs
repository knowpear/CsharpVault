//#### enum枚舉類型
/*
enum <enum_name>
{
    value1,
    value2,
    value3,
    ...
    valuen
};
枚舉類型本質就是整數類型
枚举列表中的每个符号代表⼀个整数值，⼀个⽐它前⾯的符号⼤的整数值。
默认情况下，第⼀个枚举符号的值是 0 ，可以修改默认的值
所以可以把枚举类型转成整数，来使⽤
*/
namespace Variable_enum
{
    internal class Program
    {
        //遊戲角色
        enum RoleType //枚举类型的名字 要定義在Main函數外
        {
            Mage, Archer, Assassin, Tank, Support, Warrior  //枚举类型的值
        }
        //菜单、游戏中、暂停、失败、成功
        enum GameState
        {
            Menu = 1, Running, Pause, Fail, Success
        }
        //星期幾
        enum Week
        {
            Sun, Mon, Tue = 10, Wed, Thu, Fri = 100, Sat
        }


        static void Main(string[] args)
        {
         
            RoleType role1 = RoleType.Mage; //we.只能在已開列的元素中取得值
            Console.WriteLine(role1);
           
            GameState state1 = GameState.Running;
            if (state1 == GameState.Running) 
            {
                Console.WriteLine(state1);
            }

            if (GameState.Menu == 0)
            {
                Console.WriteLine("是0");
            }

            Week day = Week.Mon;
            day = Week.Tue;
            Week nextday = Week.Fri;
            Console.WriteLine(nextday);
            int number = (int)day; //Result: 10, 輸出已指定的Tue的數值
            int number2 = (int)Week.Sun; //Result: 0, 若不指定數值, 則從0開始
            int number3 = (int)Week.Wed; //Result: 11, 從上一已給定的元素的值開始累加計數
            Console.WriteLine(day);
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }
    }
}