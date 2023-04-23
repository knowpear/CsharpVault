/*### Class
- [CsharpVault/Class at master · knownpear/CsharpVault](https://github.com/knownpear/CsharpVault/tree/master/Class)
#### 類的理解
- we.類創建了對象
- 對象就是類模板創造出來的東西
- 類是模板
- 對象是實例
- 类定义了类的每个对象（称为实例）可以包含什么数据和功能
- 每个对象都包含数据，并提供了处理和访问数据的方法
- 對象的本質就是變量. 類創建出來的變量也叫做對象(名).
- 方法的調用和省略
	- 方法名在同一類中是不能重名的, 但在不同類中是可以重名的
	- 靜態方法在其他類中是需要通過 類型.方法 調用的
	- 都是在同一類中, 可以省略類名

#### 类的定义
- 类的成員
	- 数据
	- 数据成员 : 数据成员是包含类的数据的成員
		- 字段
		- 常量
		- 事件
	- 函数
	- 函数成员: 函数成员提供了操作类中数据的某些功能.
		- 方法
		- 属性
		- 构造方法
		- 终结器(析构方法)
		- 运算符
		- 索引器
- 字段的声明
	- 访问修饰符 类型 字段名称;
- 方法的聲明
	- 访问修饰符 返回值类型 ⽅法名称(参数){//方法体}
- 數據私有化方法: 為每一個數據設置Set方法, 以讓外界可以簡潔訪問

#### 類Tips
- class Program是系統幫我們創建的類
- 文件名等於類名
- 每個文件保存一個類
- 類的外面是命名空間, 默認和項目名保持一致
- 空對象是不能使用的
- 一個類可以創建多個對象 
*/
namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ////利用类创建对象， c1就是对象名
            //Customer c1 = null ; //= new Customer();
            ////Customer c2;//声明对象
            ////c2 = new Customer();//实例化一个对象

            ////c1.name = "siki";
            ////c1.address = "北京";
            ////c1.age = 20;
            ////c1.createTime = "2021年";

            //c1.name = "www.sikedu.com";

            //c1.Show();

            //Customer c1 = new Customer();
            //Customer c2 = new Customer();
            //c1.name = "张三";
            //c2.name = "李四";
            //c1.Show();
            //c2.Show();

            //Vehicle car1 = new Vehicle();

            //car1.Run();
            //car1.Stop();

            //Vector3 v1 = new Vector3();

            ////v1.z = 12.3f;
            ////v1.x = 2.5f;

            //v1.SetX(-3);
            //v1.SetY(4.5f);
            //v1.SetZ(6.7f);

            //Console.WriteLine(v1.getX());
            //Console.WriteLine(v1.Length());

            //Customer lisi = new Customer();
            ////lisi.age = -10;
            //lisi.setAge(-10);
            //lisi.Show();

            //Customer lisi1 = new Customer();
            //lisi1.Show();
            //Customer lisi2 = new Customer();
            //Customer lisi3 = new Customer();
            Customer zhangsan = new Customer("张三", "三里屯", 20, "2021年");
            zhangsan.setAge(22); //這裡可以改變初始化賦值
            zhangsan.Show();
            //Customer[] zhangs = new Customer[2]  {zhangsan, zhangsan } ; //we.attempt

        }
    }
}
