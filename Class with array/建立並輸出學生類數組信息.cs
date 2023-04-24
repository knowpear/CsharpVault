//prompt: give me a sample in C# of creat class array with arguments
namespace Class_with_array
{
    internal class 建立並輸出學生類數組信息
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                // Create an array of Student objects with arguments
                Student[] students = new Student[] //students是類數組
                {
                    new Student("John", 20),
                    new Student("Jane", 22),
                    new Student("Bob", 19)
                };

                //#### prompt simplify it if the arguments are all same批量建立同參數類群
                //Student[] students = Enumerable.Repeat(new Student("John", 20), 3).ToArray();
                    //GPT: Create an array of Student objects with identical arguments
                    //In this example, we use the Enumerable.Repeat method to create an array of Student objects with the same Name and Age values. The first argument to Repeat is the object to repeat, and the second argument is the number of times to repeat it. We then access the properties of the Student objects in the array using a foreach loop and print them to the console.

                // Access the properties of the Student objects in the array
                foreach (Student student in students) //student是類數組成員
                {
                    Console.WriteLine("Name: {0}, Age: {1}", student.Name, student.Age);
                }
                //#### we釋義理解, students是數組
                Console.WriteLine(students[1].Name + students[1].Age);
                Console.WriteLine(students[2].Name + students[2].Age);
            }
        }
    }
}
