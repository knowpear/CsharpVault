using System.Diagnostics;

namespace Class_Virtual_Method
{
    class 虛函數加重載Main
    {
        static void Main(string[] args)
        {
            // Create a new school object
            SCHOOL mySchool = new SCHOOL("John", 40);
            
            Console.WriteLine("校長名字{0} 年齡{1}",mySchool.Name, mySchool.Age);
            mySchool.Meeting(); // Output: SCHOOL meeting

            // Create a new grade object
            GRADE myGrade = new GRADE("Jane", 30);
            Console.WriteLine("年級長名字{0} 年齡{1}",myGrade.Name, myGrade.Age);
            myGrade.Meeting(); // Output: GRADE meeting

            //創建一個雜交實例
                //we.雜交對應的父類和子類重寫形式
                    //父類private
                    //子類override
            SCHOOL sg;
            sg = new GRADE("zhangsan", 80);
            sg.Meeting(); // Output: GRADE meeting
        }
    }
}