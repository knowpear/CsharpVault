int[] numArray = new int[5] { 2, 12, 22, 0, 99 };

//Array遍歷輸出 foreach
//we.比起for , while循環, foreach不用考慮下標上限
foreach (int c in numArray)
{
    Console.WriteLine(c);
}

//Array遍歷輸出 for
for (int i = 0; i < numArray.Length; i++)
{
    Console.WriteLine(numArray[i]);
}

//Array遍歷輸出 while
int j = 0;
while (j < numArray.Length){
    Console.WriteLine(numArray[j]);
    j++;
}

//Array倒序輸出 for
for (int i = numArray.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numArray[i]);
}

//Array倒序輸出 while
int k = numArray.Length - 1;
while (k >= 0)
{
    Console.WriteLine(numArray[k]);
    k--;
}

//字符串數組 字符串是一串字符, 可看做一個字符構成的數組
string str = "abcde";

Console.WriteLine(str.Length); //str.length.取得字符长度 Result: 5
Console.WriteLine(str[4]); //str[i]访问某个字符元素, 但是不能修改某個字符 Result: e

//字符串數組的正序遍歷
foreach (char c in str) 
{
    Console.WriteLine(c);
}

//字符串數組的倒序遍歷
for (int i = str.Length-1; i >= 0; i--)
{
    Console.WriteLine(str[i]);
}