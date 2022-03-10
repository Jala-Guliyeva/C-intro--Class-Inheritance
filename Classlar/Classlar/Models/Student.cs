using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar.Models
{
    internal class Student:Human
    {
        //fields

        public double average;
        public Student(string name,string surName):base(name,surName)
        {

        }

        //constructor
        //public Student()
        //{
        //    Console.WriteLine("isledi");
        //}
        //public Student(string name) :this()
        //{
        //    this.name = name;
        //    //Console.WriteLine("Isledi");
        //}
        //public Student(string name, string surName, int age) : this(name)
        //{

        //    this.surName = surName;
        //    this.age = age;
        //}


    }
}
