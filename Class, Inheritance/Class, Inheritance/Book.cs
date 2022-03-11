using System;
using System.Collections.Generic;
using System.Text;


namespace Class__Inheritance
{
    internal class Book:Product
    {
            public string aouthorName;
            public int pageCount;
            public double discountPercent;
        public Book()
        {

        }
        public void GetInfo()
        {
            Console.WriteLine($"{aouthorName}  {pageCount}  {discountPercent}");

        }
        public double GetDiscountedPrice()

        {
            return (saledPrice - (salePrice * discountPercent) / 100);
           

        }
    }
    

    
}
