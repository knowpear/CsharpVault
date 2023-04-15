//Array賦值方法1 先聲明, 再賦值
using System.Xml.Linq;

char[] letters;
letters = new char[3]; //不賦值則系統用默認值, 此為空 //不賦值情況下, 這裡的數量3不可省略

//Array賦值方法2 聲明賦值連起來寫
char[] letters2 = new char[3] { 'a' ,'b','c'}; //賦值了這裡的數量3可以省略, 若不省略則必須值和元素數量前後一致, 好處是不用自己數了

//Array賦值方法3 聲明和賦值同行縮寫
char[] letters3 = { 'a', 'b', 'c' };

//Array元素訪問方法: 通過下標訪問某個數組元素: 數組名[索引]
Console.WriteLine(letters3[2]); //Result: c

//Array改變數組元素的值
letters3[2] = 'd';
Console.WriteLine(letters3[2]); //Result: d
