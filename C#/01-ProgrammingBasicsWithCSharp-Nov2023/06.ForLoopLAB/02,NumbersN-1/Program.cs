using System;

namespace NumbersNto1
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n;  i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}