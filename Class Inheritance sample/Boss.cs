
namespace Inherit_sample
{
    internal class Boss:Enemy
    {
        private int attack;

        //we.建立一個構造體初始化賦值函數
        public Boss(int hp, int speed, int attack)
            //RC.Quick Actions and Refactorings...- Generate constructor...- attack
        {
            //hp = hp; //這樣不行, 因為左邊會直接訪問最近的hp變量, 即它的參數. 所以要用this即當前對象
                //this的作用:1.提示該函數中成員變量有哪些 2.區分要訪問的是成員變量還是參數
            this.hp = hp; //this.hp就是此Boss類中繼承的隱含的變量
            this.speed = speed;
            this.attack = attack; //we.這裡用同名變量只是方便記憶理解或習慣, 右側換層任意變量名稱均可
        }

        public void Skill()
        {
            Console.WriteLine("Boss Skill");
        }
        
        public void Print()
        {
            //基類變量
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Speed: {speed}"); //注意這裡調用的是函數名
            //自有變量
            Console.WriteLine($"Attack: {attack}");
        }

    }
}
