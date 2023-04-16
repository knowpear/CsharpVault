namespace Class_Virtual_Method
{
    class GRADE : SCHOOL
    {
        public GRADE(string name, int age) : base(name, age) { } //死記硬背?
        //error writing
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
