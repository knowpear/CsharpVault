namespace Class_Abstract
{
    class Boss : Enemy //子類正常類
    {
        public override void Attack() //子類重寫父類抽象方法
        {
            Console.WriteLine("Boss進行攻擊");
        }
    }
}
