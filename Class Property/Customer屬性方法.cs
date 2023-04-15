/*
- 1.定义属性需要名字和类型
- 2.属性包含两个块, get块和set块
	- 当取得属性的值的时候，就会调⽤属性中的get块，所以get块，类型需要⼀个返回值就是属性的类型
	- 当我们去给属性设置值的时候，就会调用属性中的set块，我们可以在set块中通过value访问到我们设置的值
- 通过属性来访问字段
    - 我们习惯上把字段设置为私有的，这样外界不能修改字段的值，然后我们可以通过定义属性来设置和取得字段中的值
    - 习惯上属性⼤写, 字段⼩写


 */
namespace Class_Property
{
    internal class Customer屬性方法
    {
        private string name;
        private string address;
        private int age;
        private string createTime;

        //類屬性初始化get和set方法
            //习惯上属性⼤写 字段⼩写
        public int Age //當成get方法和set方法的簡寫
        {
            get
            {
                return age;
            }
            set
            {
                //Optional code
                //if (value < 0)
                //{
                //    return;
                //}
                age = value; //value是Default, 系統保留關鍵字
            }
        }

        public string CreatTime
        {
            //属性的访问修饰符
            //get和set被稱為訪問器, 默認按照屬性訪問權限即上面的public表示. 也可單獨設置權限
            //private get
            get
            {
                return createTime;
            }
            //get和set也可以二選一. 只有get即只讀. 只有set即只寫.
            set
            {
                createTime = value;
            }
        }
    }
}
