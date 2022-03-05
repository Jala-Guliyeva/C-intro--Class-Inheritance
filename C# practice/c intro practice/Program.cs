using System;

namespace c_intro_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mertebe
            //int a = 555455;
            //int count = 0;
            //while (a >= 1)
            //  {
            //      a = a / 10;
            //      count++;
            //  }
            //  Console.WriteLine(count);
            #endregion
            #region herf
            //Console.WriteLine("Sozu daxil edin: ");
            //string soz = Console.ReadLine().ToLower();
            //Console.WriteLine("Lazim olan herfi daxil edin: ");
            //char herf = char.Parse(Console.ReadLine().ToLower());
            //int count = 0;
            //for (int i = 0; i < soz.Length; i++)

            //{

            //    if (soz[i] == herf)

            //    {

            //        count++;

            //    }

            //}

            //Console.WriteLine(string.Format("'{0}' herfinden '{1}' dene var.", herf, count));
            #endregion
            #region 3e bolunme
            int[] arr = { 3, 8, 12, 27, 33, 35, 21 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);
            #endregion
        }
    }
}
