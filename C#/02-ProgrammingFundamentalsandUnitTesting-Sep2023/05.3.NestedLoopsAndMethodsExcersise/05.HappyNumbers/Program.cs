using System;

namespace HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            //•	Reads an integer number N from the console
            //•	Generate all 4 - digit happy numbers {d1}{d2}{d3}{d4} for given integer N:
            //•	A number is happy if d1 + d2 == d3 + d4 == N
            //•	Print all happy numbers

            int N = Convert.ToInt32(Console.ReadLine());

            HappyNumCalc(N);
        }

        static void HappyNumCalc(int a)
        {
            int num = 1000;
            int d1, d2, d3, d4;
            string numString = String.Empty;

            while (num < 10000)
            {
                numString = num.ToString();
                
                d1 = Convert.ToInt32(numString.Substring(0, 1));
                d2 = Convert.ToInt32(numString.Substring(1, 1));
                d3 = Convert.ToInt32(numString.Substring(2, 1));
                d4 = Convert.ToInt32(numString.Substring(3, 1));

                if (d1 + d2 == d3 + d4 && d1 + d2 == a)
                {
                    Console.Write(num + " ");
                }

                num++;
            }
        }
    }
}