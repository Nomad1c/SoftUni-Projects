using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = Convert.ToDouble(Console.ReadLine());

            double price = 1;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = quantity * 2.5;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "apple":
                        price = quantity * 1.2;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "orange":
                        price = quantity * 0.85;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapefruit":
                        price = quantity * 1.45;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "kiwi":
                        price = quantity * 2.7;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "pineapple":
                        price = quantity * 5.5;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapes":
                        price = quantity * 3.85;
                        Console.WriteLine($"{price:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = quantity * 2.7;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "apple":
                        price = quantity * 1.25;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "orange":
                        price = quantity * 0.9;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapefruit":
                        price = quantity * 1.6;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "kiwi":
                        price = quantity * 3;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "pineapple":
                        price = quantity * 5.6;
                        Console.WriteLine($"{price:F2}");
                        break;
                    case "grapes":
                        price = quantity * 4.2;
                        Console.WriteLine($"{price:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}