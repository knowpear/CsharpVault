namespace Class_Interface
{
    internal class 接口Main
    {
        static void Main(string[] args)
        {
            Plane p = new Plane();
            p.Fly();
            p.FlyAttack();

            Ifly fly; //用接口聲明一個東西, 可能是飛機, 可能是小鳥
            fly = new Plane(); //把飛機給這個fly的時候它就有了飛機的功能
            fly.Fly();
            fly.FlyAttack();
            //類似於繼承中的用父類聲明對象, 用子類去構造

            fly = new Bird(); //這裡它又變成一隻小鳥了. 這原來就叫多態
            fly.Fly();
            fly.FlyAttack();
        }
    }
}