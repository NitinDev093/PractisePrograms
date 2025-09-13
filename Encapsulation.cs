using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Encapsulation en = new Encapsulation();
//en.setname("Nitin");
//en.getname();
//en.setage(23);
//en.getage();

namespace PractisePrograms
{
    internal class Encapsulation
    {
        /*
         Encapsulation:-encapsulation in c# is a mechanisism of wrapping the data
                        (variables) and code actiing on the data(methods or properties)
                        togather as a single unit.
         */
        private string name;
        private int age;

        public void setname(string name)
        {
            if (string.IsNullOrEmpty(name)==true)
            {
                Console.WriteLine("Name Required");
            }
            else
            {
                this.name = name;
            }

        }
        public void getname()
        {
            if (string.IsNullOrEmpty(this.name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your name is " + name);
            }
        }
        public void setage(int age)
        {
            if (age>0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Invalid Age");
            }
        }
        public void getage()
        {
            if (age>0)
            {
                Console.WriteLine("Your age is:"+this.age);
            }
            else
            {

            }
        }
    }

}
