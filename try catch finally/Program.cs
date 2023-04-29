namespace try_catch_finally
{
    internal class 異常捕捉
    {
        static void Main(string[] args)
        {
            //#### 順序拋異常
            Sample.sample1();

            //#### 驗證用戶輸入, 糾正到底
            Sample.sample2();

            //#### 驗證用戶輸入, 超強糾錯
            Sample.sample3();
        }
    }
}