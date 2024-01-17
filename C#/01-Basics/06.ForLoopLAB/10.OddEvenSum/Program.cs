using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int numberAmount = Convert.ToInt32(Console.ReadLine());
            int a = 0; int b = 0; int c = 0; int d = 0;

            for (int i = 0; i < numberAmount; i++)
            {
                if (i % 2 == 0)
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    c += a;
                }
                else
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    d += b;
                }
            }

            if (c == d)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {c}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(c - d)}");
            }
        }
    }
}