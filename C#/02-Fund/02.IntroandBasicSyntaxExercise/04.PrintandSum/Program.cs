using System;

namespace PrintandSum
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int start = Convert.ToInt32(Console.ReadLine());
            int finnish = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = start; i <= finnish; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}