namespace _14_索引器
{
    class Week
    {
        private string[] days = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };

        private int GetDay(string day)
        {
            int i = 0;
            foreach (string temp in days)
            {
                if (temp == day) return i + 1;

                i++;
            }
            return -1; //如果輸入錯誤的情況
        }

        public int this[string day]
        {
            get
            {
                return GetDay(day); //we.相當於把string day傳遞給day? 意義在於觀感更有條理
            }
        }

    }
}
