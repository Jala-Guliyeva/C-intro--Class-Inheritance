using System;
using Class__Inheritance;


namespace Class__Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Book info = new Book();

            info.aouthorName = "Elxan Elatli";
            info.pageCount = 210;
            info.discountPercent = 25;
            info.saledPrice = 35;
            info.salePrice = 50;
            info.costPrice = 15;
            info.name = "Xeyanet";
            info.GetInfo();
            Console.WriteLine(info.GetDiscountedPrice());



        }

    }
   
       
 
}
