namespace Inherit_sample
{
    internal class Enemy
    {
        protected int hp;
        //protected也是私有的, 但是多一層權限, 即可以讓子類訪問
        //權限排行private < protected < public
        protected int speed;

        //we.調用speed的另一種方法
        //private int speed;
        //public int Speed { get;set; } //賦予外界對speed的讀寫權限
        
        public void AI()
        {
            Console.WriteLine("AI");
        }

        public void Move()
        {
            Console.WriteLine("Move");
        }
    }
}