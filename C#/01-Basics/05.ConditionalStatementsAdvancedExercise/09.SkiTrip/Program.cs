using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int days = Convert.ToInt32(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();
            double price;
            int nights = days - 1;

            switch (rating)
            {
                case "positive":
                    
                    switch (type)
                    {
                        case "room for one person":
                            price = nights * 18;
                            price *= 1.25;
                            Console.WriteLine($"{price:F2}");
                            break;

                        case "apartment":
                            price = nights * 25;

                            if (days < 10)
                            {
                                price *= 0.7;
                                price *= 1.25;
                                Console.WriteLine($"{price:F2}");
                            }
                            else if (days >= 10 && days <= 15)
                            {
                                price *= 0.65;
                                price *= 1.25;
                                Console.WriteLine($"{price:F2}");
                            }
                            else if (days > 15)
                            {
                                price *= 0.5;
                                price *= 1.25;
                                Console.WriteLine($"{price:F2}");
                            }
                            break;

                        case "president apartment":
                            price = nights * 35;

                            if (days < 10)
                            {
                                price *= 0.9;
                                price *= 1.25;
                                Console.WriteLine($"{price:F2}");
                            }
                            else if (days >= 10 && days <= 15)
                            {
                                price *= 0.85;
                                price *= 1.25;
                                Console.WriteLine($"{price:F2}");
                            }
                            else if (days > 15)
                            {
                                price *= 0.8;
                                price *= 1.25;
                                Console.WriteLine($"{price:F2}");
                            }
                            break;
                    }
                    break;

                case "negative":

                    switch (type)
                    {
                        case "room for one person":
                            price = nights * 18;
                            price *= 0.9;
                            Console.WriteLine($"{price:F2}");
                            break;

                        case "apartment":
                            price = nights * 25;

                            if (days < 10)
                            {
                                price *= 0.7;
                                price *= 0.9;
                                Console.WriteLine($"{price:F2}");
                            }
                            else if (days >= 10 && days <= 15)
                            {
                                price *= 0.65;
                                price *= 0.9;
                                Console.WriteLine($"{price:F2}");
                            }
                            else if (days > 15)
                            {
                                price *= 0.5;
                                price *= 0.9;
                                Console.WriteLine($"{price:F2}");
                            }
                            break;

                        case "president apartment":
                            price = nights * 35;

                            if (days < 10)
                            {
                                price *= 0.9;
                                price *= 0.9;
                                Console.WriteLine($"{price:F2}");
                            }
                            else if (days >= 10 && days <= 15)
                            {
                                price *= 0.85;
                                price *= 0.9;
                                Console.WriteLine($"{price:F2}");
                            }
                            else if (days > 15)
                            {
                                price *= 0.8;
                                price *= 0.9;
                                Console.WriteLine($"{price:F2}");
                            }
                            break;
                    }
                    break;
            }
            
        }
    }
}