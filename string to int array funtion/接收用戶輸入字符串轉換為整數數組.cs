namespace Array
{
    internal class 接收用戶輸入字符串轉換為整數數組
    {
        /*Pre: 
        接收用戶輸入字符串
        轉換函數
            接收字符串
            拆分字符串為字符串數組
            建立整數數組
            轉換字符串數組為整數數組
            返回該整數數組
        調用函數接收結果
        */

        //創建函數: static靜態 int[] 返回值: 整數數組類型 ArrayInput函數名 (string strInput接收值: 字符串)
        static int[] arrayConvert(string strInput)
        {
            //創建字符串數組接收 拆分後的字符串的返回值
            string[] sstr = strInput.Split(' ', ',', '|', '-');
            //創建整數數組, 也是該函數的返回值
            int[] intArray = new int[sstr.Length];
            //遍歷, 字符串數組中的每個元素轉換為整數, 並依次賦值到整數數組中
            for (int i = 0; i < sstr.Length; i++)
            {
                intArray[i] = Convert.ToInt32(sstr[i]);
            }

            /*轉換後的整數數組輸出測試
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
            */

            //返回值為該轉化後的整數數組
            return intArray;
        }
        static void Main(string[] args)
        {
            //接受自定義字符串
            Console.WriteLine("請輸入數組, 使用分隔符隔開");
            string strInput = Console.ReadLine();

            //調用函數, 傳入字符串到轉換函數併接收返回的整數數組
            int[] intOutput = arrayConvert(strInput);

            //輸出測試
            foreach (int i in intOutput)
            {
                Console.WriteLine(i);
            }
        }
    }
}