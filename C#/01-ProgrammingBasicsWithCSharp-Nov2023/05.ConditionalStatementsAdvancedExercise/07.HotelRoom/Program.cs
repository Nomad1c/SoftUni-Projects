using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string month = Console.ReadLine();
            double stays = Convert.ToDouble(Console.ReadLine());
            double studio, apartment;
            
            if (month == "May" || month == "October")
            {
                if (stays <=7)
                {
                    apartment = 65 * stays;
                    studio = 50 * stays;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
                else if (stays > 7 && stays <= 14)
                {
                    apartment = 65 * stays;
                    studio = 50 * stays * 0.95;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
                else if (stays > 14)
                {
                    apartment = 65 * stays * 0.9;
                    studio = 50 * stays * 0.7;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
            }

            else if (month == "June" || month == "September")
            {
                if (stays <= 7)
                {
                    apartment = 68.7 * stays;
                    studio = 75.2 * stays;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
                else if (stays > 7 && stays <= 14)
                {
                    apartment = 68.7 * stays;
                    studio = 75.2 * stays;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
                else if (stays > 14)
                {
                    apartment = 68.7 * stays * 0.9;
                    studio = 75.2 * stays * 0.8;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
            }

            else if (month == "July" || month == "August")
            {
                if (stays <= 7)
                {
                    apartment = 77 * stays;
                    studio = 76 * stays;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
                else if (stays > 7 && stays <= 14)
                {
                    apartment = 77 * stays;
                    studio = 76 * stays;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
                else if (stays > 14)
                {
                    apartment = 77 * stays * 0.9;
                    studio = 76 * stays;
                    Console.WriteLine($"Apartment: {apartment:F2} lv.");
                    Console.WriteLine($"Studio: {studio:F2} lv.");
                }
            }
        }
    }
}