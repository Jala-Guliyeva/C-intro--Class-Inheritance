using System;

namespace Task_Month
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            string month = "june";
            if (month == "december" || month == "january" || month == "february")
            {
                Console.WriteLine("winter");
            }
            else if (month == "march" || month == "april" || month == "may")
            {
                Console.WriteLine("spring");
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                Console.WriteLine("summer");
            }
            else if (month == "september" || month == "october" || month == "november")
            {
                Console.WriteLine("autumn");
            }
            else
            {
                Console.WriteLine("wrong input");
            }
            #endregion Task
        }
    }
}
