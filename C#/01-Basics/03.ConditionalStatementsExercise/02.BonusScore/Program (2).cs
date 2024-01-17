using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            double a = Convert.ToDouble(Console.ReadLine());

            if (a <= 100)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(6);
                    Console.WriteLine(a + 6);
                }
                else if (a % 5 == 0)
                {
                    Console.WriteLine(7);
                    Console.WriteLine(a + 7);
                }
                else
                {
                    Console.WriteLine(5);
                    Console.WriteLine(a + 5);
                }
            }
            else if (a > 100 && a <= 1000)
            {
                double bonus = (a / 5);
                
                if (a % 2 == 0)
                {
                    bonus++;
                    Console.WriteLine(bonus);
                    Console.WriteLine(a + bonus);
                }
                else if (a % 5 == 0)
                {
                    bonus += 2;
                    Console.WriteLine(bonus);
                    Console.WriteLine(a + bonus);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(a + bonus);
                }
            }
            else if (a > 1000)
            {
                double bonus = (a / 10);

                if (a % 2 == 0)
                {
                    bonus++;
                    Console.WriteLine(bonus);
                    Console.WriteLine(a + bonus);
                }
                else if (a % 5 == 0)
                {
                    bonus += 2;
                    Console.WriteLine(bonus);
                    Console.WriteLine(a + bonus);
                }

                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(a + bonus);
                }
            }
        }
    }
}