using System;

namespace NumberinRange
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double a = Convert.ToDouble(Console.ReadLine());

            if (a >= -100 && a<= 100)
            {
                if (a != 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else { Console.WriteLine("No"); }
        }
    }
}