using System;

namespace EvenPowersof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());

            for (double i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(2, (i + 1)));
            }
        }
    }
}