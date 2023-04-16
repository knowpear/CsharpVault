namespace Class_Derived_Class
{
    internal class BaseClass
    {
        private int hp;
        private int speed;

        public BaseClass(int hp, int speed)
        {
            this.hp = hp;
            this.speed = speed;
            Console.WriteLine("BaseClass hp, speed構造執行了");
        }

        public BaseClass()
        {
            Console.WriteLine("This is BaseClass");
        }
    }
}
