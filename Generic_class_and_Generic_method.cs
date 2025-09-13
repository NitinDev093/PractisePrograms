using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//for generic method

//Generic_class_and_Generic_method gcgm=new Generic_class_and_Generic_method();
//int[] numbers=new int[3];
//numbers[0] = 1;
//numbers[1] = 2;
//numbers[2] = 3;
//string[] names= new string[3];
//names[0] = "Nitin";
//names[1] = "Sahani";
//names[2] = "Kumar";
//gcgm.showarray(numbers);
//gcgm.showarray(names);
//Console.WriteLine(gcgm.check("Nitin","Nitin"));

//for generic class

//Example<int> exx = new Example<int>(20,30);//Constructor object create hone par hi call ho jata hai
//Example<string> exx1 = new Example<string>("Nitin");
//Example<char> exx2 = new Example<char>('N');
//int result=exx.getbox();
//string res = exx1.getbox();
//char resu=exx2.getbox();
//Console.WriteLine(result);
//Console.WriteLine(res);
//Console.WriteLine(resu);

namespace PractisePrograms
{
    /*
     Method Overloading:The method with the same name of the same method but contins
                        different parameter is called method overloading.
     Generics allow you to write a class or method that can work with any data type.
     */

    //generic methodes 
    internal class Generic_class_and_Generic_method
    {
        public void showarray<T>(T[] arr)//This is generic method
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public bool check<T>(T a, T b)
        {
            bool c = a.Equals(b);
            return c;
        }
    }
    //Generic classes
    public class Example<T>
    {
        T box;
        T boxx;
        public Example(T a,T b)//This is constructor
        {
            this.box = a;
            this.boxx = b;
        }
        public T getbox()
        {
            return this.boxx;
        }

    }

}
