using System;

namespace EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 2;

            if (b == 0)
            {
                Console.WriteLine("even");
            }

            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}