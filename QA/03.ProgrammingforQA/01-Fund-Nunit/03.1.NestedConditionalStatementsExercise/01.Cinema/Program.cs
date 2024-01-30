using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string type = Console.ReadLine();
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            if (type == "Premiere")
            {
                result = rows * columns * 12;
            }
            else if (type == "Normal")
            {
                result = rows * columns * 7.5;
            }
            else if (type == "Discount")
            {
                result = rows * columns * 5;
            }

            Console.WriteLine($"{result:F2} leva");
        }
    }
}