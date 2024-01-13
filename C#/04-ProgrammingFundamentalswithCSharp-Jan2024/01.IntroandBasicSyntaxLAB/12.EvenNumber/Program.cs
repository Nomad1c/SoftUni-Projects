using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 1)
            {
                while (n % 2 == 1)
                {
                    Console.WriteLine("Please write an even number.");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            }

            int res = Math.Abs(n);
            Console.WriteLine($"The number is: {res}");
        }
    }
}