using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Property
{
    internal class Customer無屬性方法
    {
        //無屬性方法調用流程
        private string name;
        private string address;
        private int age;
        private string createTime;

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
