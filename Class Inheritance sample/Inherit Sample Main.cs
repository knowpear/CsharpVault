namespace Inherit_sample
{
    internal class Inherit_Sample_Main
    {
        static void Main(string[] args)
        {
            Boss Boss1 = new Boss(500, 11, 100); //(hp, speed, attack)
                //we.實例化時傳參hp, attack
                    //其中hp經過二次傳遞, 即這裡傳到Boss類(它已繼承)
                        //Notice: 此處不影響其基類Enemy中的hp值, 傳到Boss只在Boss中生效
                    //attack同理, attack直接就是Boss類中的自有變量
            
            //we.調用speed的另一種方法
            //Boss1.Speed = 11; //speed由於是public, 所以可以外部直接調用

            Boss1.Print();
            Boss1.Skill();

        }
    }
}