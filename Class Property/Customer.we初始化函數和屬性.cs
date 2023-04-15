namespace Class_Property
{
    internal class weClass
    {
        //we.idea公共初始化函數做中介, 對外連接傳參返回值, 對內與成員溝通
        public string name { get; private set; }
        private int age { get; set; }
        public weClass(string name, int age) //we.?帶參數是否也可以數組批量創建
        {
            this.name = name;
            this.age = age;
        }
        public void weoutput()
        {
            name = "測試name賦值成功";
            Console.WriteLine(name + age);
        }
    }
}
