using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            double a;
            double p1Num = 0;
            double p2Num = 0;
            double p3Num = 0;
            double p4Num = 0;
            double p5Num = 0;
            double b = 0;

            for (int i = 0; i < n; i++)
            {
                a = Convert.ToDouble(Console.ReadLine());

                if (a < 200)
                {
                    p1Num++;
                }
                else if (a >= 200 && a < 400)
                {
                    p2Num++;
                }
                else if (a >= 400 &&  a < 600)
                {
                    p3Num++;
                }
                else if (a >= 600 &&  a < 800)
                {
                    p4Num++;
                }
                else if (a >= 800)
                {
                    p5Num++;
                }

                b++;
            }

            p1Num /= b; p2Num /= b; p3Num /= b; p4Num /= b; p5Num /= b;
            p1Num *= 100; p2Num *= 100; p3Num *= 100; p4Num *= 100; p5Num *= 100;
            Console.WriteLine($"{(p1Num):F2}%");
            Console.WriteLine($"{(p2Num):F2}%");
            Console.WriteLine($"{(p3Num):F2}%");
            Console.WriteLine($"{(p4Num):F2}%");
            Console.WriteLine($"{(p5Num):F2}%");
        }
    }
}