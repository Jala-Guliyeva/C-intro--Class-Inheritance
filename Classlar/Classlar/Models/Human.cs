using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar.Models
{
    internal class Human
    {
        public string name;
        public string surName;
        public int age;

        public Human(string name,string surName)
        {
            this.name = name;
            this.surName = surName;
        }

        public void Names()
        {
            Console.WriteLine($"{name} {surName} ");
        }
        public int Getage()
        {
            return age;
        }
    }
}
