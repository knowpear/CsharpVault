/*#### 結構體和類的不同
- 結構體數據存儲在棧中, 空間小, 適合小量數據
- 類的數據存儲在堆中, 空間大
- 類中成員賦值的是內存地址
- 結構體中的是數據
 */
namespace Struct___Class_diff
{
    internal class 結構體和類的區別
    {
        struct Student 
        {
            public string name;
            public int age;

            public Student(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        class Student2
        {
            public string name;
            public int age;

            public Student2(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        static void Main(string[] args)
        {
            //結構體值存儲測試
            Student s1 = new Student("小張", 18);
            Student s2 = new Student("小芳", 30);
            s1 = s2; //這裡傳遞的是值, 不受賦值方改變影響
            s2.name = "我變了";
            s2.age = 99;
            Console.WriteLine(s1.name + s1.age); //Output: 小芳30

            //類值存儲測試
            Student2 s3 = new Student2("小張", 18);
            Student2 s4 = new Student2("小芳", 30);
            s3 = s4; //這裡傳遞的是地址, 隨賦值方改變而變
            s4.name = "我變了";
            s4.age = 99;
            Console.WriteLine(s3.name + s3.age); //Output: 我變了99
        }
    }
}