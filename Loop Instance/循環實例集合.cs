//#### 輸出99乘法表
//[Csharp99chengfabiaoprethinking](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/Csharp99chengfabiaoprethinking.png)
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("{0}*{1}={2} ", j, i, j * i);
    }
    Console.WriteLine();
}

//#### 计算1 + 2 + 3 + ...+n的和
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for  (int i = 1; i < n + 1; i++) //i < n + 1 表示i 最大值是 n
{
    sum += i;
}
Console.WriteLine("sum: "+ sum);