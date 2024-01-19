using System;

namespace LowerorUpper
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            char inputChar = char.Parse(Console.ReadLine());

            if (char.IsUpper(inputChar))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}