namespace Class_weFinal
{
    internal class weMain
    {
        static void Main(string[] args)
        {
            //#### ClassAB
            //1. Initialization Instance 創建實例
            ClassAB c1 = new ClassAB(1,2,3);

            //2. 調用(get)類成員(隱含的get函數)
            //Console.WriteLine($"c1.a: {c1.a}"); //Error.'ClassAB'does not contain a definition for 'a', 別混淆, 類裡根本沒有傳參a, 都是成員A, B在裡面玩
            Console.WriteLine($"c1.A: {c1.A}");
            //Console.WriteLine($"c1.B: {c1.B}"); //error.ClassAB. B'is inaccessible due to its protection level
            Console.WriteLine($"c1.B: {c1.getB()}"); //B連get都私有, 所以用函數調用
            Console.WriteLine($"c1.C: {c1.C}");

            //3. 設置(set)類成員(隱含的set函數)
            c1.A = 4;
            Console.WriteLine($"c1.A: {c1.A}");
            //c1.B = 5; //error.inaccsessible
            c1.setB(5);
            Console.WriteLine($"c1.B: {c1.getB()}"); 
                //這裡有趣了, 因為B完全私有, 所以get, set都要用函數
                //或者用返回值函數接收
            //c1.C = 6; //error.inaccsessible
            int input = c1.setC(6);
            Console.WriteLine($"c1.A: {input}"); //這裡接收到的返回值input直接替換成setC函數也可

            //4. invoking funtion調用類函數, 直接打印類成員
            c1.Print();

            //5. invoking funtion, 傳參調用類函數
            Console.WriteLine("Add函數結果: " + c1.AddABCinput2(6));
        }
    }
}