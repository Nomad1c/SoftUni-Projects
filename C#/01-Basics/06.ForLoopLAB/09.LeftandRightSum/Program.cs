using System;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0; int b = 0;
            int totalA = 0; int totalB = 0;
            int dif = 0;

            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                totalA += a;
            }

            for (int j = 0; j < n; j++)
            {
                b = Convert.ToInt32(Console.ReadLine());
                totalB += b;
            }

            if (totalA == totalB)
            {
                Console.WriteLine($"Yes, sum = {totalA}");
            }

            else
            {
                dif = Math.Abs(totalA - totalB);
                Console.WriteLine($"No, diff = {dif}");
            }
        }
    }
}