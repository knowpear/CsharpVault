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

            //public Student() //parameterless constructor, 這裡可省略, 因為沒有其他有參構造體了
            //{

            //}
        }

        static void Main(string[] args)
        {
            //以下三種直接複製方法必須搭配缺省無參構造體或無參構造體

            //## 1. 手工簡化屬性賦值寫法
            Student student1 = new Student { ID = 1, Name = "Tom", Age = 13 };
            Student student2 = new Student { ID = 2, Name = "Mary", Age = 15 };
            Student student3 = new Student { ID = 3, Name = "Jack", Age = 16 };

            //## 2. 類數組簡化屬性賦值寫法
            Student[] aa = new Student[]
            {
                new Student { ID =1, Name = "Tom2", Age = 13 },
                new Student { ID =2, Name = "Mary2", Age = 14 },
                new Student { ID =3, Name = "Jack2", Age = 15 }
            };

            //## 3. List<T>泛型類簡化屬性賦值寫法
            List<Student> studentList = new List<Student>()
            {
                new Student { ID =1, Name = "Tom3", Age = 13 },
                new Student { ID =2, Name = "Mary3", Age = 14 },
                new Student { ID =3, Name = "Jack3", Age = 15 }
            };
        }
    }
}