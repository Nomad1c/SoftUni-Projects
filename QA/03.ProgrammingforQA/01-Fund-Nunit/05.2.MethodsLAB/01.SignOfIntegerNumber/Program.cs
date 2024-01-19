using System;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            sign(n);
        }

        static int sign(int a)
        {
            if (a == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (a > 0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if (a < 0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            return 0;
        }
    }
}