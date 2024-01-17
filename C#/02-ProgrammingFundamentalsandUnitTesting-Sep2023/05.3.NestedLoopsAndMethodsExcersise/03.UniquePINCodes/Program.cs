using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int max1 = Convert.ToInt32(Console.ReadLine()); //even
            int max2 = Convert.ToInt32(Console.ReadLine()); //2,3,5,7
            int max3 = Convert.ToInt32(Console.ReadLine()); //even

            PIN(max1, max2, max3);
        }

        static int PIN(int a, int b, int c)
        {
            int numMax = Convert.ToInt32($"{a}{b}{c}");
            int num = 0;

            for (int i = 2; i <= a; i += 2)
            {
                for (int j = 2; j <= b; j++)
                {
                    if (j == 4 || j == 6)
                    {
                        j++;
                    }

                    else
                    {
                        for (int k = 2; k <= c; k += 2)
                        {
                            num = Convert.ToInt32($"{i}{j}{k}");
                            Console.WriteLine(num);
                        }
                    }
                }
            }

            return 0;
        }
    }
}