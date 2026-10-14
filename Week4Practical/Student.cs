using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Practical
{
    class Student
    {
        //private fields
        private int id;
        private string name;
        private int age;


        //public properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value ; }
        }


        //method to print all 3 details
        public void Display()
        {
            Console.WriteLine($"ID:  {Id}");
            Console.WriteLine($"Name:  {Name}");
            Console.WriteLine($"Age:  {Age}");

        }


    }
}
