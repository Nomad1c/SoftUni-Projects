using System;

namespace TheGreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Greater number: {num1}");
            }

            else if (num1 < num2)
            {
                Console.WriteLine($"Greater number: {num2}");
            }

            else
            {
                Console.WriteLine("The two numbers are equal.");
            }
        }
    }
}