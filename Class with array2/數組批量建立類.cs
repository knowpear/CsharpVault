//#### Prompt: give me an example of creating a batch of class using array, be simply
using System.Xml.Linq;

namespace Class_with_array2
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    internal class 數組批量建立類
    {
        static void Main(string[] args)
        {
            //#### Method 1
            //Student[] students = new Student[3]; //we.別忘了students是數組, 是成員類型的數組
            //students[0] = new Student("Tom", 18){ Name= "Tom2", Age = 182 }; //we.{}後面內可以二次賦值
            //students[1] = new Student("Jane", 19);
            //students[2] = new Student("Herry", 20);

            //#### Method 2
            Student[] students = new Student[]
            {
                new Student("Tom", 18),
                new Student("Jane", 19),
                new Student("Herry", 20)
            };

            //#### 遍歷輸出
            foreach (Student student in students)
            //foreach (var student in students) //alternative writing
            {
                Console.WriteLine(student.Name + " " + student.Age);
            }
        }
    }
}