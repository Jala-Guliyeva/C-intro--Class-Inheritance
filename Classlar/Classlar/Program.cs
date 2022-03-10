using System;
using Classlar.Models;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new Student("Jale", "Quliyeva",21);
            //stu1.name = "Jale";
            //stu1.surName = "Quliyeva";
            //stu1.age = 21;
            //stu1.Names();
            //stu1.Getage();
            //Console.WriteLine(stu1.Getage());
            //Console.WriteLine(stu1.age);

            //Student stu2 = new Student("Ilknur","Ezizov",19);
            //stu2.name = "Elgun";
            //stu2.surName = "Qocayev";
            //stu2.age = 20;
            //stu2.Names();
            //stu2.Getage();
            //Console.WriteLine(stu2.Getage());
            //Console.WriteLine(stu2.age);
            Student stu3 = new Student("Jale","Quliyeva",21);
            //stu3.age = 22;
            stu3.Names();
            //Console.WriteLine(stu3.name);

            //Developer dev = new Developer("program","prog");
            ////dev.age = 25;
            //Console.WriteLine(dev.name);


        }
    }
    internal class Student
    {
        //fields
       public string name;
        public string surName;
        public int age;

        //constructor
        public Student()
        {
           // Console.WriteLine("isledi");
        }
        public Student(string name) : this()
        {
            this.name = name;
            //Console.WriteLine("Isledi");
        }
        public Student(string name, string surName, int age) : this(name)
        {

            this.surName = surName;
            this.age = age;
        }

        public void Names()
        {
            Console.WriteLine($"{name} {surName} ");
        }
        public int Getage()
        {
            return age;
        }
}   }
