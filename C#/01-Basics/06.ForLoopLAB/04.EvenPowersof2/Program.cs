using System;

namespace EvenPowersof2
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            double a = 0;

            for (int i = 0; i  <= n; i += 2)
            {
                a = Math.Pow(2, i);
                Console.WriteLine(a);
            }
        }
    }
}