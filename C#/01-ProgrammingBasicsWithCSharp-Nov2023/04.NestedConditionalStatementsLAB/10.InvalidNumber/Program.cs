using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 100 && a <= 200)
            {
                    Console.WriteLine("");
            }
            else if (a == 0)
            {
                Console.WriteLine("");
            }
            else { Console.WriteLine("invalid"); }
        }
    }
}