using System;
using System.Collections.Generic;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            //Exception Handling with try catch block 
           
            try
            {
                string stringNumber;
                int intNumber;

                Console.WriteLine("Please enter a number");
                stringNumber = Console.ReadLine();
                intNumber = Convert.ToInt32(stringNumber);

                Console.WriteLine("Your number divides 2 is {0}", intNumber / 2);
                Console.ReadLine();
            }
            catch (FormatException ex) //Assigning to varibale ex which is a data type format exception
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex) //General exeption
            {
                Console.WriteLine(ex.Message);
            }
            finally //Prevent console from closing immediately
            {
                Console.ReadLine();
            }
        }
    }
}