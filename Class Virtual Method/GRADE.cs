namespace Class_Virtual_Method
{
    class GRADE : SCHOOL
    {
        //適用於父類有構造的情況
        public GRADE(string name, int age) : base(name, age) { }
        //error寫法解析
            //差別在於父類是否構造, 子類是否構造
            //父類無構造, 子類才可以如此構造
        //public GRADE(string name, int age)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //}
        public virtual void Meeting() //虛方法
        {
            Console.WriteLine("GRADE meeting");
        }
    }
}