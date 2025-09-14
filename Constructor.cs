using PractisePrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Use this in main method

//Console.WriteLine("Enter name");
//string name = Console.ReadLine();
//Console.WriteLine("Enter Age");
//int age = Convert.ToInt32(Console.ReadLine());
//Constructor c = new Constructor(name, age);
//c.showname();

namespace PractisePrograms
{
    internal class Constructor
    {
        string Name;
        int Age;
        public Constructor(string name, int age)//Constructor
        {
            this.Name = name;
            this.Age = age;
        }
        public void showname()
        {
            Console.WriteLine("Hello Your name Is:" + Name);
            Console.WriteLine("Your Age is :" + Age);
        }

    }
}
