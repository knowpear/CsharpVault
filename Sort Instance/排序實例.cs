//#### 三個數取最大值
using System.ComponentModel.DataAnnotations;

int a1 = 5;
int b1 = 12;
int c1 = 3;
int max = a1; //先假設a為最大
if (b1 > max)
{
    max = b1;
}
if (c1 > max)
{
    max = c1;
}
Console.WriteLine("最大值是: " + max);

//#### 初級冒泡排序 用戶輸入3個整數, 從小到大排序輸出
Console.WriteLine("用戶輸入3個整數, 從小到大排序輸出");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int temp;
if (a > b) //a>b就交換a, b, 實現a小b大
{
    temp = a;
    a = b;
    b = temp;
}
if (b > c ) //b>c就交換b,c, 實現b小c大
{
    temp = b;
    b = c;
    c = temp;
}
if (a > b) //前面比較完成後, a,b都小於c, 再次比較a,b即可
{
    temp = a;
    a = b;
    b = temp;
}
//若不滿足, 則說明b本來就小與c
Console.WriteLine("{0},{1},{2}", a, b, c);

//#### 冒泡排序
//we寫法
int[] array2 = new int[] { 1, 0, 4, 76, 28, 0 };
int temp2;
bool isChange = false; //設置一個旗幟變量, 以監視該輪次是否發生了變量交換
for (int i= 0; i < array2.Length - 1; i++) //注意: 這裡i是輪次, 不是位置! 別搞混了
{
    for (int j = 0; j < array2.Length - 1 -  i; j++) //每一輪都把最大的數移動到最後了, 所以內循環比較次數遞減
    {
        if (array2[j] > array2[j+1])
        {
            temp2 = array2[j];
            array2[j] = array2[j + 1];
            array2[j + 1] = temp2;
            isChange = true; //發生交換則旗幟改為true
        }
    }
    if (!isChange) //如果false, 即這一輪沒發生交換, 說明數組是有序的, 無需再排序, 所以可直接退出循環
    {
        break;
    }
}

//we寫法 實際是冒泡排序變種, 依次把最小值放在前面
//for (int i = 0; i < array.Length - 1; i++)
//{
//    for (int j = i + 1; j < array.Length; j++) //j已經再自增了, 注意不要重複
//    {
//        if (array[i] > array[j]) //大於則直接交換即可
//        {
//            temp1 = array[i];
//            array[i] = array[j];
//            array[j] = temp1;
//        }
//    }
//}

Console.WriteLine("冒泡排序是: ");
foreach (int x in array2)
{
    Console.WriteLine(x);
}

//#### 選擇排序
//we.選擇排序與冒泡排序的本質區別是前者過程中只交換下標, 結果中交換變量, 後者過程中即交換所有變量
int[] array = new int[] { 1, 0, 4, 76, 28, 0 };
int temp1;
int min;

for (int i = 0; i < array.Length - 1; i++)
{
    min = i;
    for (int j = i + 1; j < array.Length; j++) //j已經在自增了, 注意不要重複
    {
        if (array[min] > array[j])
        {
            min = j; //we.意思可能是依次遍歷, 但只交換下標, 遍歷結束才根據下標交換元素
        }
        temp1 = array[min];
        array[min] = array[i];
        array[i] = temp1;
    }
}
//老師寫法
//for (int i = 0; i < array.Length - 1; i++)
//{
//    min = i;
//    for (int j = i + 1; j < array.Length; j++) //j已經在自增了, 注意不要重複
//    {
//        if (array[min] > array[j])
//        {
//            min = j; //we.不理解. 過濾中間已遍歷元素, 走捷徑? 讓min跳躍已過濾數
//        }
//        temp1 = array[min];
//        array[min] = array[i];
//        array[i] = temp1;
//    }
//}

////以下是we錯誤寫法, we.? re.變量作用域?
//for (int i = 0; i < array.Length - 1; i++)
//{
//    min = array[i];
//    for (int j = i + 1; j < array.Length; j++) //j已經再自增了, 注意不要重複
//    {
//        if (min > array[j])
//        {
//            temp1 = min;
//            min = array[j];
//            array[j] = temp1;
//        }
//    }
//}
Console.WriteLine("選擇排序是: ");
foreach (int x in array)
{
    Console.WriteLine(x);
}

