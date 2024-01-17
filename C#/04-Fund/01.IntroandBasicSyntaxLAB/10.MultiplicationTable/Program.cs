using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 0;

            for (int i = 1; i <= 10; i++)
            {
                res = n * i;

                Console.WriteLine($"{n} X {i} = {res}");
            }
        }
    }
}