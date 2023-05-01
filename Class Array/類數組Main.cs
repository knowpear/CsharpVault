namespace Class_Array
//prompt: give me a sample in C# of creat class array with arguments
{
    internal class 類數組Main
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
                //#### Oldschool Method 1
                //Student[] students = new Student[3]; //we.別忘了students是數組, 是成員類型的數組
                //students[0] = new Student("Tom", 18){ Name= "Tom2", Age = 182 }; //we.{}後面內可以二次賦值
                //students[1] = new Student("Jane", 19);
                //students[2] = new Student("Herry", 20);

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
