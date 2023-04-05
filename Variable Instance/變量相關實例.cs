//#### 求整數的千位百位十位個位
int num = 2625;
int qianwei = num / 1000 % 10;
int baiwei = num / 100 % 10;
int shiwei = num / 10 % 10;
int gewei = num % 10;
Console.WriteLine("千位是{0}, 百位是{1}, 十位是{2}, 各位是{3}", qianwei, baiwei, shiwei, gewei);