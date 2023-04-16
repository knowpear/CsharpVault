namespace Class_Virtual_Method
{
    class GRADE : SCHOOL
    {
        //適用於同時構造的情況
        public GRADE(string name, int age) : base(name, age) { } //死記硬背?
        //error寫法解析
            //差別在於父類是否構造, 子類是否構造
            //適用於儘在父類或子類構造的情況
        //public GRADE(string name, int age)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //}
        public virtual void Meeting()
        {
            Console.WriteLine("GRADE meeting");
        }
    }
}
