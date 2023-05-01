namespace Class_Property_Final
{
    internal class Program
    {
        public class Student
        {
            //#### 字段屬性
            public int ID { get; set; }
            public string Name;
            public int Age { get; set; }

            //#### 初始化函數
            public Student(int id, string name, int age)
            {
                this.ID = id;
                this.Name = name;
                this.Age = age;
            }
        }

        static void Main(string[] args)
        {

        }
    }
}