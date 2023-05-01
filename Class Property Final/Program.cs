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
                //we.idea公共初始化函數做中介, 對外連接傳參返回值, 對內與成員溝通
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
                if (value < 0) return; //we.小於0不合法, 不設置
                this.Age = value;
            }
            //公私合營只讀的Num的setter方法
            public void setNum(int value)
            {
                if (value < 0)
                {
                    Num = -1 ; //we.小於0不合法, 返回-1
                }
                else
                {
                    this.Num = value; //否則傳參賦值成功
                }
            }
            //公私合營只寫的Num2的getter方法
            public int getNum2()
            {
                return this.Num2;
            }

            //## 函數
            //### 無參打印函數
            public void Print() //這裡不能加static
            {
                Console.WriteLine
                    (
                    "ID: " + ID + "\n" +
                    "Name: " + Name + "\n" +
                    "Age: " + Age + "\n" +
                    "Num: " + Num + "\n" +
                    "Num2: " + Num2
                    );
            }
            //### 有參有返回值函數
            public string comboOutput(string value)
            {
                string temp = ID + Name + Age + Num + Num2 + value;
                return temp;
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student(01, "Tom", 12, 6, 8);
            //student.setAge(66);
            Console.WriteLine(student.getAge());
            Console.WriteLine(student.ID);

            student.Print();

            string temp = student.comboOutput("完畢");
            Console.WriteLine(temp);

            student.setAge(-9);
            Console.WriteLine(student.getAge());
            student.setNum(-10);
            Console.WriteLine(student.Num);
        }
    }
}