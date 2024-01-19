using System;

namespace RefactorVolumeofPyramid
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            Console.WriteLine("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = (length * width * height) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}