using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Word("Salam")); //task2


            //int[] arr = { 5, -3, 8, -9, -12, 15 };
            //Array(arr);
            //for (int i = 0; i<arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


        }

        static int[] Array(int[] arr)

        {
            #region task1

            //    for (int i = 0; i < arr.Length; i++)
            //    {

            //        if (arr[i] < 0)
            //        {
            //            arr[i] *= (-1);
            //        }


            //    }
            //    return arr;
            #endregion
            static string Word(string arr)
            {
                #region task2
                char[] chars = new char[arr.Length];
                for (int i = 0, j = arr.Length - 1; i <= j; i++, j--)
                {
                    chars[i] = arr[j];
                    chars[j] = arr[i];
                }
                return new string(chars);
                {

                }
                #endregion
            }


        }
    }
}

     



