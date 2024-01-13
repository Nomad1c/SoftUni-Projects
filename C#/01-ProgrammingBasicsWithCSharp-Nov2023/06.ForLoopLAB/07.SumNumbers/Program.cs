using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int numberAmount = Convert.ToInt32(Console.ReadLine());
            int number = 0;
            int total = 0;

            for (int i = 0; i < numberAmount; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                total = total + number;
            }

            Console.WriteLine(total);
        }
    }
}