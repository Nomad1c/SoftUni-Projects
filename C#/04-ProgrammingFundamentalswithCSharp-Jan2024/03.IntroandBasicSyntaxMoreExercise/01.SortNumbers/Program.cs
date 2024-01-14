using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    a = n;
                    n = Convert.ToInt32(Console.ReadLine());
                }

                else if (i == 1)
                {
                    if (n > a)
                    {
                        b = a;
                        a = n;
                    }

                    else
                    {
                        b = n;
                    }

                    n = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    if (n > a)
                    {
                        c = b;
                        b = a;
                        a = n;
                    }

                    else if (n <= a && n > b)
                    {
                        c = b;
                        b = n;
                    }

                    else if (n <= a && n <= b)
                    {
                        c = n;
                    }
                }
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}