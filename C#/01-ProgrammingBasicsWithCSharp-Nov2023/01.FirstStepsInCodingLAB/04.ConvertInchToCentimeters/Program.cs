using System;

namespace ConvertInchToCentemeters
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            double a = Convert.ToDouble(Console.ReadLine());
            double b = a * 2.54;
            Console.WriteLine(b);
        }
    }
}