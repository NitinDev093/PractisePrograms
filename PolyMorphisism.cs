using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PolyMorphisism pm=new PolyMorphisism();
//pm.Add(2,3);
//pm.Add("Nitin","Sahani");
//pm.Add(1.5f,2.5f);

namespace PractisePrograms
{
    internal class PolyMorphisism
    {
        /*
         * Four pillar of oops:-Inheritance,polymorphisim,encapsulation,abstraction.
         PolyMorphisim:-By using this we can perform a single action by different ways.
                         Poly means many and morphs means forms.
        Types of pm:-1:-Static pm or(compile time pm)
                      2:-Dynamic pm or(run time pm)
        1:-static pm:-The mechanisism of linking a function with an object 
                      during compile time is called static pm or early binding.
                      it is also callled static binding.
        C# provides two techinques to implement static pm.They are........
        *Method or Function Overloading.
        *Operator Overloading.
         */


        //MethodOverloading:-A function with same name but different signature in a
                             //class is called funtionn overloading.
        
        public void Add()
        {
            int a = 20;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a , int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(string a,string b)
        {
            string c = a +" "+ b;
            Console.WriteLine(c);
        }
        public void Add(float a , float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
    }
    //Operator overloading we will see later...

    /*
         2:-Dynamic polymorphisism or rut time pm:-It is achived by method overriding
         Method Overriding:-If derived class defines same method as defined in its base
                            class it is known as method overriding.
        * To perform method overrdiding in c# you need to use virtual keyword with 
         base class method and override keyword with derived class method.
        
    */
    //Method overriding
    public class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is a method of parent class");
        }
    }
    public class Child:Parent 
    {
        public override void print()
        {
            Console.WriteLine("This is a method of child class");
        }
    }
}
