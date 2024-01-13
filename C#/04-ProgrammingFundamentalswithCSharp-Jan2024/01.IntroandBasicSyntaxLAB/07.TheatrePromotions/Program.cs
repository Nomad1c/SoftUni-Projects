using System;

namespace TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string day = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                switch (day)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("5$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (day)
                {
                    case "Weekday":
                        Console.WriteLine("18$");
                        break;
                    case "Weekend":
                        Console.WriteLine("20$");
                        break;
                    case "Holiday":
                        Console.WriteLine("12$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else if (age > 64 && age <= 122)
            {
                switch (day)
                {
                    case "Weekday":
                        Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        Console.WriteLine("10$");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}