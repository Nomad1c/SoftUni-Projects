using System;

namespace GreetingbyName
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}