namespace Class_Operator_Overloading_ToString
{
    internal class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //#### 自動重載ToString
        //操作方法: RC.Quick Actions and Refactorings...- Generate overrides...
        //public override string? ToString()
        //{
        //    return base.ToString();
        //}

        //#### 手動重載ToString
        public override string ToString()
        {
            string result = name + " " + age;
            return result;
        }
    }
}
