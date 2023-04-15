using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Property
{
    internal class Customer屬性方法簡寫
    {
        private string name;
        //private string address;
        private int age;
        private string createTime;

        //簡寫方法1
        public string Name
        //we.?doubt它會直接找到跟你的屬性所對應的首字母小寫的數據成員(即上面的name), 會自動得到並設置它(name)
        //we.實測成員name可以省略. 賦值取代聲明?
        {
            get;set;
        }

        //簡寫方法2 自動實現的屬性
        public string Address { get; set; } //我們沒有定義address, 系統會自動創建一個這樣的數據成員.

        public void show()
        {
            name = "屬性方法簡寫調用了"; //we.這句測試出似乎name和Name沒有關係, 兩個不同的變量
            Console.WriteLine("名字是: " +  Name);
                //we.?這裡小寫name為null, 添加code name = Name; 則生效
            Console.WriteLine("地址是: " + Address); //因為我們沒有定義這樣一個數據成員, 所以這裡要用屬性去訪問了
        }
    }
}
