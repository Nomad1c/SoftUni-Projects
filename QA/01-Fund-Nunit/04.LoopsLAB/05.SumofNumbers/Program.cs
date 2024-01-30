using System;

namespace SumofNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int initial = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            int sum = 0;

            while (true)
            {
                if (sum >= initial)
                {
                    break;
                }

                else
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    sum += num;
                }
            }

            Console.WriteLine(sum);
        }
    }
}