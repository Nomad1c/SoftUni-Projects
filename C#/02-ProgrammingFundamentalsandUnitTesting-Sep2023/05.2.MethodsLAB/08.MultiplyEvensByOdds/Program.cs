using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int result = MultiplyEvensOdds(a);
            Console.WriteLine(result);
        }

        static int MultiplyEvensOdds(int a)
        {
            int x = SumEvens(a);
            int y = SumOdds(a);

            return x * y;
        }

        static int SumOdds(int a)
        {
            int length = Convert.ToString(a).Length;
            int sum = 0;
            string stringA = Convert.ToString(a);
            string letter = "";
            int num = 0;

            for (int i = 0; i < length; i++)
            {
                letter = stringA.Substring(i, 1);
                num = Convert.ToInt32(letter);

                if (num % 2 == 1)
                {
                    sum += num;
                }
            }

            return sum;
        }

        static int SumEvens(int a)
        {
            int length = Convert.ToString(a).Length;
            int sum = 0;
            string stringA = Convert.ToString(a);
            string letter = "";
            int num = 0;

            for (int i = 0; i < length; i++)
            {
                letter = stringA.Substring(i, 1);
                num = Convert.ToInt32(letter);

                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}