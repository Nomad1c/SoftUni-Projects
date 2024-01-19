using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            

            string a = Console.ReadLine();
            string c = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine(a + b + c);
        }
    }
}