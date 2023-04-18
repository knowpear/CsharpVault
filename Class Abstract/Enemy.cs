namespace Class_Abstract
{
    abstract class Enemy //父類抽象類
    {
        private int hp;
        private int speed;
        public void Move()
        {
            Console.WriteLine("Move");
        }
        public abstract void Attack(); //抽象方法
            //Output: Boss進行攻擊
    }
}