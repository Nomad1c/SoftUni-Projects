using System;

namespace NumbersFrom1toNReversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(n - i);
            }
        }
    }
}