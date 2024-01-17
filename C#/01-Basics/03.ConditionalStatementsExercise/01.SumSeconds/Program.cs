using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int d = a + b + c;

            int minutes = d / 60;
            int seconds = d % 60;

            TimeSpan timeSpan = new TimeSpan(0, minutes, seconds);
            string formattedTime = $"{timeSpan:m\\:ss}";

            Console.WriteLine(formattedTime);
        }
    }
}