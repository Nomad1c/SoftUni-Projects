using System;

namespace PastryShop
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string pastryName = Console.ReadLine();
            double number = Convert.ToDouble(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            double price = 0;

            if (day <= 15 && day > 0)
            {
                switch (pastryName)
                {
                    case "Cake":
                        price = number * 24;
                        break;

                    case "Souffle":
                        price = number * 6.66;
                        break;

                    case "Baklava":
                        price = number * 12.6;
                        break;
                }
            }

            else if (day > 15 && day < 25)
            {
                switch (pastryName)
                {
                    case "Cake":
                        price = number * 28.7;
                        break;

                    case "Souffle":
                        price = number * 9.8;
                        break;

                    case "Baklava":
                        price = number * 16.98;
                        break;
                }
            }

            if (day <= 22)
            {
                if (price >= 100 && price <= 200)
                {
                    price *= 0.85;
                }

                else if (price > 200)
                {
                    price *= 0.75;
                }

                if (day > 0 && day <= 15)
                {
                    price *= 0.9;
                }
            }
            


            Console.WriteLine($"{price:F2}");
        }
    }
}