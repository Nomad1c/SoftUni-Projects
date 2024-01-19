using System;

namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string n = String.Empty;
            double a = 0;

            while (true)
            {
                n = Console.ReadLine();

                if (n == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {total:F2}");
                    break;
                }

                else
                {
                    a = Convert.ToDouble(n);

                    if (a >= 0)
                    {
                        total += a;
                        Console.WriteLine($"Increase: {a:F2}");
                    }

                    else
                    {
                        Console.WriteLine($"Total: {total:F2}");
                        break;
                    }
                }
                

            }
        }
    }
}