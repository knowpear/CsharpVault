//#### 循環輸入判斷求和
//让用户输入整数,如果用户输入的不是 0,就继续输入,如果输入的是 0,结束整数,并输出所有整数的和

//while實現法
int sum = 0;
while (true)
{
    Console.WriteLine("請輸入");
    int int_input = Convert.ToInt32(Console.ReadLine());
    if (int_input == 0)
    {
        Console.WriteLine("是0");
        break;
    }
    else
    {
        Console.WriteLine("不是0, 重新輸入");
    }
    sum += int_input;
}
Console.WriteLine("總和" + sum);

//do while實現法
int int_input2;
int sum2 = 0;
do
{
    Console.WriteLine("請輸入");
    int_input2 = Convert.ToInt32(Console.ReadLine());
    sum2 += int_input2;

} while (int_input2 != 0); //但是do while特性起始無判斷, 故無法插入上面的輸入提示用戶的功能
Console.WriteLine("是0");
Console.WriteLine("總和" + sum2);