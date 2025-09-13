using PractisePrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//permanentemployees pe = new permanentemployees();
//pe.empid = 12;
//visitingemployees ve = new visitingemployees();
//ve.empid = 13;
//Console.WriteLine(pe.empid);
//Console.WriteLine(ve.empid);
//ve.show();

namespace PractisePrograms
{
    /*
    Inheriatance:-Inheritance allows you to adopt the feature of another class. 

    Parent class means existing class or base class.
    Child class means which we create or derived class.
     */
    //internal class InheretanceLearning
    //{
    //}

    //This is multi level inheritance-:Isme ek parent class hoti hai aur ek se jayda
                                       //child class hoti hai
    public class visitingemployees:Employees//derived class or child class of Employees
    {
        public int visitingsalary;
        public int visitinhours;
    }
    public class permanentemployees: Employees//derived class or child class of Employees
    {
        public int permanentsalary;
        public int permanenthours;
    }

    //yeh wo class hai jo uper ke dono class ki parent hai
    public class Employees//base class or parent class
    {
        public int empid;
        public string empname;
        public int empage;
        public int empconnumber;

        public void show()
        {
            Console.WriteLine("This is method of base class");
        }

    }
    ////Types of inheritance
    /*
     1.Multi level inheritance:- .It is above that we study
     2.Single inheritance:-isme ek parent class hoti hai aur ek hi child class hoti hai.
     3.Hierirchical inheritance:-isme ek base class aur multiple derived class hote hai.

    */


}
