using System;

namespace SequenceofNumbers2kPlus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 1;

            while (a <= n)
            {
                Console.WriteLine(a);
                a = a * 2 + 1;
            }
        }
    }
}