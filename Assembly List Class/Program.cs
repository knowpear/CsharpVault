namespace Assembly_List_Class
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
            //#### List Class寫法 Notice: 不能有初始化函數!
            List<Student> studentList = new List<Student>()
            {
                new Student { ID =1, Name = "Tom2", Age = 13 },
                new Student { ID =2, Name = "Mary2", Age = 14 },
                new Student { ID =3, Name = "Jack2", Age = 15 }

            };

            //studentList 是一個 List<Student> 類型的變數，它保存了多個 Student 對象的集合。
            //在這個代碼中，studentList 初始化為一個包含三個 Student 對象的集合，
            //每個 Student 對象都有一個唯一的 ID、Name 和 Age 屬性值。

            // 訪問第一個學生的名字
            string firstName = studentList[0].Name;

            // 向學生列表中添加一個新的學生
            Student newStudent = new Student { ID = 4, Name = "David", Age = 16 };
            studentList.Add(newStudent);

            // 遍歷所有學生並顯示他們的名字和年齡
            foreach (Student student in studentList)
            {
                Console.WriteLine("Name: {0}, Age: {1}", student.Name, student.Age);
            }
        }
    }
}