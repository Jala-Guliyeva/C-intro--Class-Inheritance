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
            info.saledPrice = 20;
           
            info.costPrice = 15;
            info.name = "Xeyanet";
            info.GetInfo();



        }

    }
    //internal class Product
    //{
    //    //fields
    //    public string name;
    //    public int costPrice;
    //    public int saledPrice;
    //}
    //internal class Book:Product
    //{
    //    public string aouthorName;
    //    public int pageCount;
    //    public double discountPercent;


       
    //}
}
