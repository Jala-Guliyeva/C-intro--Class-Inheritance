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
            Console.WriteLine($"{aouthorName},{pageCount},{discountPercent},{ name},{costPrice },{saledPrice }");

        }
        public double GetDiscountedPrice(double actualprice)

        {
            double r = 0.1;
            return actualprice * (1 - r);
           

        }
    }
    

    
}
