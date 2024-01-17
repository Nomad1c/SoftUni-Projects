using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            //Input
            string product = Console.ReadLine();                    //Продукт
            string city = Console.ReadLine();                       //Град
            double amount = Convert.ToDouble(Console.ReadLine());   //Количество

            switch (city)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            Console.WriteLine(amount * 0.5);
                            break;
                        case "water":
                            Console.WriteLine(amount * 0.8);
                            break;
                        case "beer":
                            Console.WriteLine(amount * 1.2);
                            break;
                        case "sweets":
                            Console.WriteLine(amount * 1.45);
                            break;
                        case "peanuts":
                            Console.WriteLine(amount * 1.6);
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            Console.WriteLine(amount * 0.4);
                            break;
                        case "water":
                            Console.WriteLine(amount * 0.7);
                            break;
                        case "beer":
                            Console.WriteLine(amount * 1.15);
                            break;
                        case "sweets":
                            Console.WriteLine(amount * 1.3);
                            break;
                        case "peanuts":
                            Console.WriteLine(amount * 1.5);
                            break;
                    }
                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            Console.WriteLine(amount * 0.45);
                            break;
                        case "water":
                            Console.WriteLine(amount * 0.7);
                            break;
                        case "beer":
                            Console.WriteLine(amount * 1.1);
                            break;
                        case "sweets":
                            Console.WriteLine(amount * 1.35);
                            break;
                        case "peanuts":
                            Console.WriteLine(amount * 1.55);
                            break;
                    }
                    break;

            }

        }
    }
}