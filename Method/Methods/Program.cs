using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //double numbers = Metod(25, 100);
            //Console.WriteLine(numbers);
            //Task1
            //Task2
            //Console.WriteLine(Repeat("Ha!", 5));
            //Task2
            //Task3
            Random rnd = new Random();
            int[] numeral = new int[10];
            for (int i = 0; i < numeral.Length; i++)
            {
                numeral[i] = rnd.Next(1, 50);
            }
            Console.WriteLine("The sum of the elements in an array :" + Number(numeral));
            Console.ReadKey();
            ////Task3

            static double Metod(double num1, double num2)
            {
                #region Task1

                ////    //return num1 / num2;
                #endregion
            }

            static string Repeat(string word, int count)
                {

                    #region Task2
                    //    //    //var result = string.Empty;

                    //    //    //for (var i = 0; i < count; i++)
                    //    //    //    result += word;

                    //    //    //return result;
                    #endregion


                }
              
            static int Number(int[] arr)
            {
                #region Task3
                int total = 0;
                for (int i = 0; i < arr.Length; ++i)
                    total += arr[i];
                return total;
                #endregion
            }
        }
    }
}
