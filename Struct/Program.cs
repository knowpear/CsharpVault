//#### 結構體
/*
we.結構體的使用: 1. 屬性集合歸納成類 2. 類具體成概念 3. 概念當類用
结构体的作⽤就是把某⼀类的变量进⾏整合，组成⼀个新的数据类型，相当于⼀个新的信息
⽐如学⽣信息（包含了 年龄，姓名、年级、学号）
we.和enum區別是Struct定義的是變量, 而enum裡面都直接是值
we.struct聲明的是再聲明層次上, enum聲明是在賦值內. 二者層次不同, 可能struct聲明出來的內容就是enum本體?
we.struct聲明的是屬性, enum聲明的是值

struct <name>
{
访问权限 type typename;
访问权限 type typename;
}
 */
namespace Struct
{
    internal class Program
    {
        struct StudentInfo
        {
            public int age;
            public string name;
            public int grade;
            public int id;
            public bool gender;//true false
        }
        
        struct Position
        {
            public int x;
            public int y;
            public int z;
        }
        static void Main(string[] args)
        {
            //不使用結構體
            /*
            int student1Age = 10;
            string student1Name = "siki";
            int student1Grade = 2;
            int student1StudyID = 10213023;

            int student2Age = 20;
            string student2Name = "micheal";
            int student2Grade = 1;
            int student2StudyID = 10223023;

            int student3Age = 30;
            string student3Name = "micheal";
            int student3Grade = 1;
            int student3StudyID = 10223023;

            int[] stuAge = new int[10];
            string[] stuName = new string[10];
             */

            //使用結構體
            StudentInfo student1;
            student1.age = 10;
            student1.name = "小明";
            student1.grade = 2;
            student1.id = 10102103;

            //Console.WriteLine(student1.name);

            StudentInfo[] students = new StudentInfo[10];
            students[0].age = 30;

            Console.WriteLine(students[0].age); //Result: 30

            Position position;
            position.x = 10;
            Console.WriteLine(position.x); //Result: 10

            Position[] a = new Position[3];
            a[2].x = 6;
            Console.WriteLine(a[2].x); //Result: 6
        }
    }
}
