namespace Class_Instantiation
{
    internal class Program
    {
        public class Student
        {
            public int ID;
            public string Name;
            public int Age;
            public int Num;
            public int Num2{ get; set; }

            public Student() //parameterless constructor, 在有有參構造體情況下, 無參構造體不會成為缺省設置, 必須獨立聲明
            {

            }
            public Student(int id, string name, int age, int num, int num2)
            {
                this.ID = id;
                this.Name = name;
                this.Age = age;
                this.Num = num;
                this.Num2 = num2;
            }
        }

        static void Main(string[] args)
        {
            //## 1. 手工調用
            Student student1 = new Student(01, "Tom", 12, 6, 8);
            Student student2 = new Student(02, "Jerry", 13, 6, 8);

            //## 2. 類數組調用
            Student[] students = new Student[]
            {
                new Student (1, "zhang3", 13, 6, 8),
                new Student (2, "li4", 14, 6, 8),
                new Student (3, "wang5", 15, 6, 8)
            };
            
            Console.WriteLine("## 2. 類數組調用");
            foreach (Student stu in students)
            {
                Console.Write(" ID: " + stu.ID);
                Console.Write(" Name: " + stu.Name);
                Console.Write(" Age: " + stu.Age);
                Console.Write(" Num: " + stu.Num);
                Console.WriteLine(" Num2: " + stu.Num2);
            }

            //## 3. List<T>泛型調用
            //### 3.1 集合手動添加方法
            List<Student> stulist = new List<Student>(); //stulist是 Student類的成員們的集合體

            //创建两个学生对象并添加到学生列表中
            Student stu1 = new Student(1, "Tom", 18, 1001, 2001);
            stulist.Add(stu1);
            Student stu2 = new Student(2, "Jerry", 20, 1002, 2002);
            stulist.Add(stu2);
            
            Console.WriteLine("### 3.1 集合手動添加方法");
            Console.WriteLine(stulist[0].Name); //Output: Tom | stulist[0]即Student類 stulist集合體的索引0的對象
            Console.WriteLine(stulist[1].Name); //Output: Jerry

            //#### 3.2 集合初始化器语法
            List<Student> stulist2 = new List<Student>()
            {
                new Student(1, "Tom", 18, 1001, 2001),
                new Student(2, "Jerry", 20, 1002, 2002),
                new Student(3, "Mary", 19, 1003, 2003)
            };

            Console.WriteLine("### 3.2 集合初始化器语法");
            Console.WriteLine(stulist2[0].Name); //Output: Tom
            Console.WriteLine(stulist2[1].Name); //Output: Jerry

            //#### 3.3 对象初始化器语法
            //Notice使用对象初始化器语法时，需要保证被初始化的属性在类中是可访问的.此例中省略初始化函數猜可用
            List<Student> stulist3 = new List<Student>() //parameterless constructor是為它而生的
            {
                new Student { ID = 1, Name = "Tom", Age = 18, Num = 1001, Num2 = 2001 },
                new Student { ID = 2, Name = "Jerry", Age = 20, Num = 1002, Num2 = 2002 },
                new Student { ID = 3, Name = "Mary", Age = 19, Num = 1003, Num2 = 2003 }
            };
            foreach (Student stu3 in stulist3)
            {
                Console.WriteLine(stu3.Name);
            }

        }
    }
}