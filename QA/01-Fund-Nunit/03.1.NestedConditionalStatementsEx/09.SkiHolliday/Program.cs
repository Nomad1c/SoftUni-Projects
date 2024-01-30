using System;

namespace SkiHoliday
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int daysToStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string assessment = Console.ReadLine();

            double roomForOnePersonPrice = 118.00;
            double apartmentPrice = 155.00;
            double presidentApartmentPrice = 235.00;

            double totalPrice = 0;

            switch (roomType)
            {
                case "room for one person":
                    totalPrice = daysToStay * roomForOnePersonPrice;
                    break;
                case "apartment":
                    totalPrice = daysToStay * apartmentPrice;
                    break;
                case "president apartment":
                    totalPrice = daysToStay * presidentApartmentPrice;
                    break;
                default:
                    Console.WriteLine("Invalid room type.");
                    return;
            }

            if (daysToStay > 15)
            {
                switch (roomType)
                {
                    case "apartment":
                        totalPrice *= 0.50;
                        break;
                    case "president apartment":
                        totalPrice *= 0.80;
                        break;
                }
            }
            else if (daysToStay >= 10)
            {
                switch (roomType)
                {
                    case "apartment":
                        totalPrice *= 0.65;
                        break;
                    case "president apartment":
                        totalPrice *= 0.85;
                        break;
                }
            }
            else
            {
                switch (roomType)
                {
                    case "apartment":
                        totalPrice *= 0.70;
                        break;
                    case "president apartment":
                        totalPrice *= 0.90;
                        break;
                }
            }

            if (assessment == "positive")
            {
                totalPrice *= 1.25;
            }
            else if (assessment == "negative")
            {
                totalPrice *= 0.90;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}