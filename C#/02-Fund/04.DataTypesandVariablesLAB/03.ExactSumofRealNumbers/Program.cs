using System;

namespace ExactSumofRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}