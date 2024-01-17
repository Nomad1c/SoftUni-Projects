using System;

namespace Divisableby3
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}