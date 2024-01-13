using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            string type = Console.ReadLine();

            if (type == "square")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (type == "rectangle")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (type == "circle")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.PI * a * a);
            }
            else if (type == "triangle")
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(a * b / 2);
            }
        }
    }
}