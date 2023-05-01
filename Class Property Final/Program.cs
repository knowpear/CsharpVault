using System.Xml.Linq;

namespace Class_Property_Final
{
    internal class Program
    {
        public class Student
        {
            //## 字段
            //公有
            public int ID; //we.相當於省略了後面的{ get; set; }?
            //私有
            private string Name;
            private int Age { get; set; }
            //公私合營
            public int Num { get; private set; } //只讀
            
            public int Num2 { private get; set; } //只寫

            //## 初始化函數
            //### parameter constructor
            public Student() //預留給類的簡化直接賦值的實例的
            {

            }
            //### parameterless constructor
            public Student(int id, string name, int age, int num, int num2)
            {
                this.ID = id;
                this.Name = name;
                this.Age = age;
                this.Num = num;
                this.Num2 = num2;
            }
            
            //## 字段屬性
            //私有的Name getter和setter方法
            public string getName()
            {
                return this.Name;
            }
            public void setName(string value)
            {
                this.Name = value;
            }
            //私有的Age getter和setter方法
            public int getAge()
            {
                return this.Age;
            }
            public void setAge(int value)
            {
                this.Age = value;
            }
            //公私合營只讀的Num的setter方法
            public void setNum(int value)
            {
                this.Num = value;
            }
            //公私合營只寫的Num2的getter方法
            public int getNum2()
            {
                return this.Num2;
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student(01, "Tom", 12, 6, 8);
            //student.setAge(66);
            Console.WriteLine(student.getAge());
            Console.WriteLine(student.ID);
        }
    }
}