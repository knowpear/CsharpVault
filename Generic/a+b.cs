namespace Generic
{
    internal class ClassA<T> //Type int string double
    {// MyClass
        private T a;
        private T b;
        public ClassA(T a, T b) //泛型初始化賦值函數
        {
            this.a = a;
            this.b = b;
        }
        public T GetSum() //泛型函數
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic result = num1 + num2;
            return (T)result; //強制轉換成泛型
        }
    }
}
