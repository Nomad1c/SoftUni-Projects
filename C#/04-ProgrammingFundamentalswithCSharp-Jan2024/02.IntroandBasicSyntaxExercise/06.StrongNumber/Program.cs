using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string input = Console.ReadLine();
            string a = string.Empty;
            int sum = 0;
            int num = 0;
            int inputNum = Convert.ToInt32(input);

            for (int i = 0; i < input.Length; i++)
            {
                a = input.Substring(i, 1);
                num = Convert.ToInt32(a);
                num = FactorialSumer(num);
                sum += num;
            }

            if (sum == inputNum)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }

        static int FactorialSumer(int a)
        {
            int mult = 1;
            
            for (int i = 1;i <= a; i++)
            {
                mult *= i;
            }

            return mult;
        }
    }
}