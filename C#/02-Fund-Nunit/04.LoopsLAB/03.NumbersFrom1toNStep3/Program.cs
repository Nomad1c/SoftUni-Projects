using System;

namespace NumbersFrom1toNStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i+=3)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}