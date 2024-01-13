using System;

namespace ExcursionSale
{
    class Program
    {
        static void Main(string[] _)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int holidaySea = Convert.ToInt32(Console.ReadLine());
            int holidayMountain = Convert.ToInt32(Console.ReadLine());
            int a = holidaySea + holidayMountain;
            string input = String.Empty;
            int profit = 0;


            while (a > 0)
            {
                input = Console.ReadLine();

                if (input == "sea" && holidaySea > 0)
                {
                    profit += 680;
                    holidaySea--;
                    a--;
                }

                else if (input == "mountain" && holidayMountain > 0)
                {
                    holidayMountain--;
                    profit += 499;
                    a--;
                }

                else if (input == "Stop") { break; }
            }

            if (a == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }

            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}