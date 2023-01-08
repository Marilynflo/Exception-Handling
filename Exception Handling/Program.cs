using System;
using System.Collections.Generic;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            try    //Exception Handling with try catch block
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) //catching format exception 
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex) //Exception to not divide by zero
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex) //General exeption
            {
                Console.WriteLine(ex.Message);
            }
            finally //Always run the program and has a database log
            {
                Console.ReadLine();
            }
        }
    }
}