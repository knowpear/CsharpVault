//#### ASCII
//[ASCII图片_百度百科](https://baike.baidu.com/pic/ASCII/309296/1/e850352ac65c103880a07b53bc119313b17e8941?fr=lemma&ct=single#aid=1&pic=e850352ac65c103880a07b53bc119313b17e8941)
namespace ASCII
{
    internal class ASCII碼
    {
        static void Main(string[] args)
        {
            //#### 字符變ASCII碼 方法即char強塞給int 或 char強制轉換為int
            //weThinking.ASCII就是int, 字符就是char, 就是它們的相互轉換
            char a = 'c';
            int b = a;
            //int容器大, char容器小, 這裡char a直接塞給int b
            //char字符類型也是整數形式存儲的, 字符類型可以當做整數類型使用, 見ASCII. 所以左右類型一致(整數型), 才可以賦值
            //int b= Convert.ToInt32(a); 等同於上句
            Console.WriteLine(a);
            Console.WriteLine(b);

            //#### ASCII碼變字符 方法即int強塞給char 或 int強制轉換為char
            int d = 97;
            //char e = d; 報錯, 大容器int 不能賦值給小容器char
            //int d容器大, char e容器小, 這裡int d只能強塞給char e
            char e = (char)d; //強塞, 強制類型轉換. 轉換成char才能輸出為字符we.這是廢話..
            //char e = Convert.ToChar(d); 等同於上句
            Console.WriteLine(e);

            //#### 判断是否為字母或數字幾
            Console.WriteLine("#### 判断是否為字母或數字幾");
            char input = Convert.ToChar(Console.ReadLine()); //轉換string為char

            if (input >= 'a' && input <= 'z' || input >= 'A' && input <= 'Z')
            //if (input >= 97 && input <= 122 || input >= 65 && input <= 90) 
            //或者寫成對應的ASCII碼. we.即char可以直接和int做比較. 表面是char之間比較, 實際陰性的是ASCII碼之間的比較
            {
                Console.WriteLine("您輸入的是字母");
            }
            else if (input >= '0' && input <= '9')
            {
                Console.WriteLine("您輸入的是數字是: " + (input - '0'));
                //這裡'0'對應ASCII碼是48, input數字對應ASCII數值減去數字起始數值所得的差值即是自身的數值
            }
            else
            {
                Console.WriteLine("您輸入的不是字母也不是數字");
            }
            int asciiNum = (int)input; //(int)is redundant
            Console.WriteLine("對應的ASCII是" + asciiNum);
        }
    }
}