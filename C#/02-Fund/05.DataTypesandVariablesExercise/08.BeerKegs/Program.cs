using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            double biggestVolume = 0;
            string biggestName = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = Convert.ToDouble(Console.ReadLine());
                double height = Convert.ToDouble(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestName = model;
                }
            }

            Console.WriteLine(biggestName);
        }
    }
}