using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int x = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;

            while (a < x)
            {
                b = Convert.ToInt32(Console.ReadLine());
                a += b;
            }

            Console.WriteLine(a);
        }
    }
}