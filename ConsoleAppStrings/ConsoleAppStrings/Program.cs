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
                Console.WriteLine("Please enter a number:");
                int ans = Convert.ToInt32(Console.ReadLine());
                List<int> myNumbers = new List<int> { 2, 4, 6, 8, };
                foreach (int myNumber in myNumbers) 
                {

                    Console.WriteLine(ans/ myNumber);
                }
               
              
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