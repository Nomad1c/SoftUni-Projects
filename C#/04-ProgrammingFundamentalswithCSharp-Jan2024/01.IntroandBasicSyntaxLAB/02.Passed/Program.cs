using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade > 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}