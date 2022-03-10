using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar.Models
{
    class Developer:Human
    {
      
        public double salary;
        public Developer(string name,string surName):base(name,surName)
        {

        }

        //constructor
        //public Developer()
        //{
        //    Console.WriteLine("isledi");
        //}
        //public Developer(string name) : this()
        //{
        //    this.name = name;
        //    //Console.WriteLine("Isledi");
        //}
        //public Developer(string name, string surName, int age) : this(name)
        //{

        //    this.surName = surName;
        //    this.age = age;
        //}

        
    }
}
