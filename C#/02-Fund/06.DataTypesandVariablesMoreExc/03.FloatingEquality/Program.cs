using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            a *= 100000; b *= 100000;

            int inta = Convert.ToInt32(a);
            int intb = Convert.ToInt32(b);

            bool result = inta == intb;

            Console.WriteLine(result);
        }
    }
}