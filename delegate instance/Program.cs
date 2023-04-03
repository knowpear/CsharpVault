namespace delegate_instance
{
    internal class Program
    {
        delegate void OnDieDelegate();
        static void Play(OnDieDelegate onDie)
        {
            Console.WriteLine("做任务");
            Console.WriteLine("玩家正在战斗");
            Console.WriteLine("死亡");
            
            //第一示例
            onDie();

            //第二示例
            //if (onDie != null)
            //{
            //    onDie();
            //}
        }

        static void ShowDieUI()
        {
            Console.WriteLine("显示游戏死亡后的UI");
            Console.WriteLine("返回首页UI");

        }
        static void Main(string[] args)
        {
            // A主角
            // BUI 菜单

            //第一示例
            Play(ShowDieUI); //we.相當於藉助委託為橋, 把一個函數概念(抽象出的委託公式再賦值成的一個更抽象的概念/代號)作為參數傳遞到另一個函數中

            //第二示例
            //Play(null); 
        }
    }
}