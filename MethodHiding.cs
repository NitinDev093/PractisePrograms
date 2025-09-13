using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ChildOrDerived cd= new ChildOrDerived();
//3:-ParentOrBase pb = new ChildOrDerived();
//pb.show();
//2:-((ParentOrBase)cd).show();
//cd.show();

namespace PractisePrograms
{
    internal class MethodHiding
    {
        /*
         Method Hiding:-Method hiding occurs in inheritance relationship when base 
                        class and derived class both have a method with same name 
                        and same signature 
        When we create the object of derived class it will hide the base class
        method and will call its own method and this is callled method hiding
        or name hding in c# inheritance.
        If we do not use new keyword then compiler will raise only warning but 
        program will work fine.

        //Different wayes to call a hidden base class member from derived class
        1:-Use Base Keyword
        2:-Cast Child Type To Parent Type And Invoke The Hidden Member
        3:-ParentClass PC=new ParentClass();
           PC.HiddenMethod();
         */
    }

    public class ParentOrBase
    {
        public void show()
        {
            Console.WriteLine("Parent Class Method");
        }
    }
    public class ChildOrDerived : ParentOrBase
    {
        public new void show()
        {
           //1:- base.show();
            //Console.WriteLine("Child Class Method");
        }
    }
}
