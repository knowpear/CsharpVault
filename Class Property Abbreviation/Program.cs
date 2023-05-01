namespace Class_Property_Abbreviation
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
            //public Student(int id, string name, int age)
            //{
            //    this.ID = id;
            //    this.Name = name;
            //    this.Age = age;
            //}
        }

        static void Main(string[] args)
        {
            //#### 簡化屬性賦值寫法1 Notice: 不能有初始化函數!
            Student student1 = new Student { ID = 1, Name = "Tom", Age = 13 };
            Student student2 = new Student { ID = 2, Name = "Mary", Age = 15 };
            Student student3 = new Student { ID = 3, Name = "Jack", Age = 16 };

            //#### 簡化屬性賦值寫法2 Notice: 不能有初始化函數!
            List<Student> studentList = new List<Student>()
            {
                new Student { ID =1, Name = "Tom2", Age = 13 },
                new Student { ID =2, Name = "Mary2", Age = 14 },
                new Student { ID =3, Name = "Jack2", Age = 15 }
            };
        }
    }
}