using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double total = 0;
            string input = "";
            double sum = 0;
            input = Console.ReadLine();

            while (input != "NoMoreMoney")
            {

                if (input != "NoMoreMoney")
                {
                    sum = Convert.ToDouble(input);
                }

                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {total:F2}");
                }

                else
                {
                    Console.WriteLine($"Increase: {sum:F2}");
                    total += sum;
                }

                input = Console.ReadLine();
            }

            if (input == "NoMoreMoney")
            {
                Console.WriteLine($"Total: {total:F2}");
            }
        }
    }
}