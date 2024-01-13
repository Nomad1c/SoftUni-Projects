using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            for (int i = y; i <= 10; i++)
            {
                res = x * i;

                Console.WriteLine($"{x} X {i} = {res}");
            }
        }
    }
}