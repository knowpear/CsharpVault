//#### 判断是否為字母或數字幾
//寫法1 轉換string為char
char input = Convert.ToChar(Console.ReadLine());

if (input >= 'a' && input <= 'z' || input >= 'A' && input <= 'Z')
//if (input >= 97 && input <= 122 || input >= 65 && input <= 90) //或者寫成對應的ASCII碼. we.即char可以直接和int做比較
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
int asciiNum = (int)input;
Console.WriteLine("對應的ASCII是" + asciiNum);

//#### 求整數的千位百位十位個位
int num = 2625;
int qianwei = num / 1000 % 10;
int baiwei = num / 100 % 10;
int shiwei = num / 10 % 10;
int gewei = num % 10;
Console.WriteLine("千位是{0}, 百位是{1}, 十位是{2}, 各位是{3}", qianwei, baiwei, shiwei, gewei);

