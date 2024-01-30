using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int a = Convert.ToInt32(Console.ReadLine());
            a *= a;
            Console.WriteLine(a);
        }
    }
}