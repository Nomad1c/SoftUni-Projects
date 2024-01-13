using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int numberAmount = Convert.ToInt32(Console.ReadLine());
            int number = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < numberAmount; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                
                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}