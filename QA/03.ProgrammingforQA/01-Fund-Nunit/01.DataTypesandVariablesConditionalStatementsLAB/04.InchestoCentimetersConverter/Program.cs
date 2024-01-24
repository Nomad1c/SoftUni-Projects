using System;

namespace InchestoCentimetersConverter
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double inch = Convert.ToDouble(Console.ReadLine());
            double cm = inch * 2.54;
            Console.WriteLine(cm);
        }
    }
}