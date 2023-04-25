namespace Equals
{
    class Student
    {
        private int age;
        private string name;

        public Student(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            Student stu = (Student)obj; 
            //這裡是強制類型轉換. 把obj強制轉換成Student類對象. 可以這樣做是因為我們傳遞進來的是一個Student類對象

            //if (age == stu.age && name == stu.name)
            if (age == stu.age && name == stu.name)
            {
                return true;
            }
            return false;
        }
    }
}