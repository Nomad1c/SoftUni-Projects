using System;

namespace NumbersFrom1to100
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int a = 1;
            
            for (int i = 1; i <= 100; i += 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}