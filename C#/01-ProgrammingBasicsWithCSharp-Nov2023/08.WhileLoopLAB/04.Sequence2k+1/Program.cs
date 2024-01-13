using System;

namespace Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double n = Convert.ToDouble(Console.ReadLine());
            double a = 1;
            
            while (a <= n)
            {
                Console.WriteLine(a);
                a = a * 2 + 1;
            }
        }
    }
}