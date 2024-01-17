using System;

namespace NumberFrom100To200
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (a >= 100 &&  a <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}