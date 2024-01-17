using System;

namespace NumbersNto1WithStep3
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1;  i <= a; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}