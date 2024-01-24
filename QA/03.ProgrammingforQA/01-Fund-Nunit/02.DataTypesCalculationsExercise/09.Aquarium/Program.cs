using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volumeCm3 = length * width * height;

            double volumeLiters = volumeCm3 * 0.001;

            double occupiedSpace = percentage / 100.0;
            double requiredLiters = volumeLiters * (1 - occupiedSpace);

            Console.WriteLine($"{requiredLiters:F2}");
        }
    }
}
