//子類1
namespace Inherit
{
    internal class DrivedClass1:BaseClass
    {
        public int data3 = 3;

        public void FunctionDrivedClass1()
        {
            //base.Function1(); //base可用於在子類中調用父類中的函數
            Console.WriteLine("FunctionDrivedClass1");
        }
    }
}
