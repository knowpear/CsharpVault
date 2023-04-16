namespace Class_weFinal
{
    internal class ClassAB
    {
        //#### public method
        //declaration聲明- 成員
        public int A;
        private int B { get; set; }
        public int C { get; private set; }

        //assignment賦值- constructor 類的構造函數
        public ClassAB(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        //defining function定義函數

        //取得私有成員b的值的函數
        public int getB() 
        {
            return this.B;
        }
        public void setB(int value)
        {
            this.B = value;
        }
        public int setC(int input)
        { 
            C = input;
            return input;
            //return this.C = input; //簡寫
        }

        //無參打印函數
        public void Print() //這裡不能加static
        {
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("C: " + C);
        }
        
        //有參有返回值函數
        public int AddABCinput2(int input2)
        //private int AddABC() //error.外界(Main函數)無法調用
        {
            return A + B + C + input2;
        }
    }
}
