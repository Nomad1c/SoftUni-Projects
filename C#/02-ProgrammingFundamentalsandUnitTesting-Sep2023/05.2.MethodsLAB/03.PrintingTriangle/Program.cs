using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int n = Convert.ToInt32(Console.ReadLine());

            Triangle(n);
        }

        static int Triangle(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{j}");
                    }

                    else
                    {
                        Console.Write($"{j} ");
                    }
                }

                Console.WriteLine();
            }

            for (int k = (a - 1); k >= 1; k--)
            {
                for (int l = 1; l <= k; l++)
                {
                    if (k == l)
                    {
                        Console.Write($"{l}");
                    }

                    else
                    {
                        Console.Write($"{l} ");
                    }
                }

                Console.WriteLine();
            }

            return 0;
        }
    }
}