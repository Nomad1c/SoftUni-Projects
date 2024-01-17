using System;

namespace SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            double a = Convert.ToDouble(Console.ReadLine());

            if (a <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (a > 10 && a <= 50)
            {
                Console.WriteLine("average");
            }
            else if (a > 50 && a <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (a > 150 && a <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else { Console.WriteLine("extremely fast"); }
        }
    }
}