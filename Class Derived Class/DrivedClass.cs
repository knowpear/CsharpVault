namespace Class_Derived_Class
{
    internal class DrivedClass:BaseClass
    {
        private int attack;

        public DrivedClass(int attack)
        {
            this.attack = attack;
            Console.WriteLine("attack構造執行了");
        }

        public DrivedClass(int hp, int speed, int attack):base(hp,speed)
                //這裡是把hp, speed傳遞到父類裡調用其構造函數
                //在子類裡調用父類裡的構造函數 //這裡即使省略base()也會先調用父類函數
        {
            this.attack = attack; //we.hp, speed外包, attack自己計算
            Console.WriteLine("This is Drived Class");
        }
    }
}
