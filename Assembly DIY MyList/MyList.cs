
namespace Assembly_DIY_MyList
{
    internal class MyList<T>
    {
        //#### 創建了一個長度為0的數組, 即空數組
        private T[] data = new T[0];
        //we.?它和Main函數中的新建的集合體MyList<int> list = new MyList<int>();是如何聯繫起來的呢? 靠泛型中的T?
            //[CsharpVSchatGPTanswer](https://we-1307938470.cos.ap-beijing.myqcloud.com/pictures/CsharpVSchatGPTanswer.png)
        //假如不new, 相當於空的, 後面會出現引用錯誤.
        //不賦值相當於private T[] data; 或private T[] data = null; 會出現System. NullReferenceException
        //所有的引用類型都是需要通過new去賦值的

        //#### 創建一個Capacity屬性
        public int Capacity 
        {
            get
            { 
                return data.Length; //數組的容量就是其長度
            }
        }
        //#### 定義元素/數據個數
        private int count = 0;

        //#### 公共化Count屬性, 用於讓外界訪問我們的列表裡有多少個元素
        public int Count
        {
            get
            {
                return count;
            }
        }

        //#### 添加Add方法
        public void Add(T item)
        {
            //判斷: 數組長度為0時不能添加數據
            if (data.Length == 0) 
            {
                data = new T[4]; //則創建一個長度為4的數組
            }

            //判斷: 添加元素之前, 要先判斷數組元素是否已經滿了
            if (count == data.Length)
            {
                //錯誤寫法
                //data = new T[count*2]; //這樣寫data原有的數組就沒人引用它了, 造成數據丟失

                //正確寫法: 創建新的數組, 把原有的數據搬過來之後再進行引用的更換
                T[] temp = new T[count * 2]; //藉助新創建的臨時數組
                for(int i = 0; i < data.Length; i++) //用for循環是為了拿到索引, 而foreach做不到這點
                {
                    temp[i] = data[i];
                }
                data = temp; //移花接木
            }

            //count就是元素的個數, count的個數就跟我們要添加到數組中的索引的位置是相等的
            data[count] = item; //所以添加數據就添加到和count相同的索引位置即可
            count++; //這裡的count不是Default
        }
        //#### 索引器
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > count - 1)
                {
                    throw new ArgumentOutOfRangeException($"索引index超出範圍了");
                    //拋是為了指向原因, 在這裡不能處理
                    //使用情況: 當我們寫的類給別人使用時
                }
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}