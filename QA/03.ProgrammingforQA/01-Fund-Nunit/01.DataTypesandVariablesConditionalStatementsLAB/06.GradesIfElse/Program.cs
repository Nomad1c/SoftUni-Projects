using System;

namespace GradesIfElse
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade > 5.5)
            {
                Console.WriteLine("Excelent!");
            }
            else
            {
                Console.WriteLine("Not excelent.");
            }
        }
    }
}