using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            string name = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            int hours = num * 3;

            Console.WriteLine("The architect " + name + " will need " + hours + " hours to complete " + num + " project/s.");
        }
    }
}