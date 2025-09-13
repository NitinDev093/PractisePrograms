using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lists lt= new Lists();
//lt.learninglistconcepts();  

namespace PractisePrograms
{
    internal class Lists
    {
        public void learninglistconcepts()
        {
            //==============================//
            //int add = 0;
            //List<int> mynumbers = new List<int>();
            //Console.WriteLine("How many numbers want u to add?");
            //int count=Convert.ToInt32(Console.ReadLine());
            //for (int i=0;i<count;i++)
            //{
            //    Console.WriteLine("Enter number");
            //    int value=Convert.ToInt32(Console.ReadLine());
            //    mynumbers.Add(value);
            //}
            //Console.WriteLine("Your entered number addition is");
            //for (int i=0;i<mynumbers.Count;i++)
            //{
            //    add = mynumbers[i] + add;
            //}
            //Console.WriteLine(add);


            //mynumbers.Add(11);
            //mynumbers.Add(22);
            //mynumbers.Add(33);
            //mynumbers.Add(44);
            //mynumbers.Add(55);

            //Console.WriteLine(mynumbers.Count);
            //foreach (int item in mynumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Sorted--------------------------List");
            // mynumbers.Sort();
            //mynumbers.AddRange(mynumbers);
            //mynumbers.Insert(1,10);
            //mynumbers.InsertRange(2,mynumbers);
            //mynumbers.Remove(33);
            //mynumbers.RemoveAt(0);
            //mynumbers.RemoveRange(2,3);
            //mynumbers.Clear();
            //foreach (int item in mynumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(mynumbers[1]);



            //=============================//
            //List<string> names = new List<string>();
            //names.Add("Nitin");
            //names.Add("Kumar");
            //names.Add("Sahani");
            //names.Add("Ashish");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}



            //============================//
            //Employee employee1 = new Employee()
            //{
            //    name = "Nitin",
            //    age = 23,
            //    desigination="manager",
            //};
            //Employee employee2 = new Employee()
            //{
            //    name = "Ashish",
            //    age = 23,
            //    desigination = "operator",
            //};
            //Employee employee3 = new Employee()
            //{
            //    name = "Indresh",
            //    age = 23,
            //    desigination = "dev",
            //};
            //List<Employee> employees = new List<Employee>();
            //employees.Add(employee1);
            //employees.Add(employee2);
            //employees.Add(employee3);
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine("{0} {1} {2}",emp.name,emp.age,emp.desigination);
            //}

            //===================================//
            //List<int> ob = new List<int>();
            //Console.WriteLine("How many numbers you want to add in your list?");
            //int count = Convert.ToInt32(Console.ReadLine());
            //for (int i=0;i<count;i++)
            //{
            //    Console.WriteLine("Enter your value {0}",i);
            //    int value=Convert.ToInt32(Console.ReadLine());
            //    ob.Add(value);

            //}
        }
    }
    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public string desigination { get; set; }
    }
}
