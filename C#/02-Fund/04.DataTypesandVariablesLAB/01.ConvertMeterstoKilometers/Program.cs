using System;

namespace ConvertMeterstoKilometers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int meters = Convert.ToInt32(Console.ReadLine());
            double km = Convert.ToDouble(meters) / 1000;

            Console.WriteLine($"{km:F2}");
        }
    }
}