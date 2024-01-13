using System;

namespace SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 1;

            while (i <= n)
            {
                sum += i * 2 - 1;
                Console.WriteLine(i * 2 - 1);
                i++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}