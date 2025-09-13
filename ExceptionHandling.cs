using PractisePrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Exception Handling//
//ExceptionHandling eh = new ExceptionHandling();
//eh.dividiebyzeroexception();
//eh.indexoutofrangeexception();
//eh.nullreferenceexception();
//eh.trywithmultiplecatch();
//eh.finallyblockwithtrycatchblock();
//eh.throwkeyword();


namespace PractisePrograms
{
    /*it stops the flow of our program when it occures
     An exception is a c# object that represents an error.we use exception handling to 
    avoid the exception
    When exception occures:3 things happened
    1.program terminates or program crashes
    2.ugly kind of messages is displayed tha user can never ever understand
    3.statements after exception will not be executed
     */
    /*
     Exception Handling:It handle the runtime error so that normal folw of the 

     */
    internal class ExceptionHandling
    {
        //divide by zero exception................
        public void dividiebyzeroexception()
        {
            Console.WriteLine("Enter first number");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                int result = num1 / num2;
                Console.WriteLine("Division result is:" + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide a number by a zero");
                //we can use both either custom message or exception message
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Remaining statement 1");
            Console.WriteLine("Remaining statement 2");
            Console.WriteLine("Remaining statement 3");
        }
        //index out of range exception
        public void indexoutofrangeexception()
        {
            int[] arr = new int[3];
            try
            {
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Array size is exceded");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Statement 1....");
        }
        //handiling null referenceexception
        public void nullreferenceexception()
        {
            try
            {
                string name = null;
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("No string is available to show you length");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Statement....");
        }
        //try block with multiple catches
        public void trywithmultiplecatch()
        {
            try
            {
                //    int a = 10;
                //    int b = 0;
                //    int c = a / b;
                //string a = null;
                //Console.WriteLine(a.Length);
                int[] arr = new int[3];
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
                arr[3] = 4;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //finally block with try catch block
        /*finally block is always executed wheather exception is occurs or not.
        finally block is always executed wheather exception is handelede or not.
        it is used to execute important code such as closing connection,stream etc.
        finally block flows try or catch block
        */
        public void finallyblockwithtrycatchblock()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executeed--");
            }
        }
        //throw keyword:it is use to throw exception according our way as we want
        public void throwkeyword()
        {
            //try
            //{
            //    Console.WriteLine("Enter Age for check for vote");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("You are eligible to vote");
            //    }
            //    else
            //    {
            //        throw new Exception("You are not eligible for vote");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                int account_balance = 5000;
                int withdrawal_balance = 6000;
                if (account_balance < withdrawal_balance)
                {
                    throw new Exception("Insuccificent balance");
                }
                else
                {
                    account_balance = account_balance - withdrawal_balance;
                    Console.WriteLine("Remainig balance is: " + account_balance);
                    Console.WriteLine("Transction completed successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
