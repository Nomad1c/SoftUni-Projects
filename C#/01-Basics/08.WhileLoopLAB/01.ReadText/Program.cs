using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            string text = "";

            while (text != "Stop")
            {
                text = Console.ReadLine();
                if (text != "Stop")
                {
                    Console.WriteLine(text);
                }
            }
        }
    }
}