using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int result = Power(a, b);
            Console.WriteLine(result);
        }

        static int Power(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
    }
}