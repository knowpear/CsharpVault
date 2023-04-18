namespace Modifier_Static
{
    internal class Test //static class Test 靜態類裡面只能包含靜態成員, 所以下面的hp不能存在
    {
        public int hp; //hp是分別存儲於對象中的
        //靜態字段或靜態變量
            //靜態字段代表這個字段被所有的Test對象所共享的.
            //這個字段只能通過類來訪問, 不能通過Test對象訪問
            //靜態字段是存儲於靜態儲存區中的
        public static int count; 
        //靜態函數只能使用靜態數據
        public static void Move()
        {
            Console.WriteLine(count);
            Console.WriteLine("移動");
            //Console.WriteLine(hp); //error.An object reference is required for the non-static field, method, or property 'Test. hp
        }
    }
}
