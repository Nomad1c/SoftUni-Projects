using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            //  Write a program that:
            //      •	Reads a string on the first line from the console, representing a product -"coffee",  "water", "coke" or "snacks"
            //      •	Reads an integer on the second line from the console, representing the quantity of the product
            //      •	Create a method that calculates and prints the total price of an order
            //      •	The method should receive two parameters: product and quantity
            //      •	The prices for a single item of each product are:
            //          	coffee – 1.50
            //          	water – 1.00
            //          	coke – 1.40
            //          	snacks – 2.00
            //      •	Print the result, rounded to the second decimal place

            string product = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());

            double result = PriceCalc(product, num);
            Console.WriteLine($"{result:F2}");
        }

        static double PriceCalc(string a, int b)
        {
            double result = Double.NaN;
            
            switch (a)
            {
                case "coffee":
                    result = 1.5 * b;
                    break;

                case "water":
                    result = b;
                    break;

                case "coke":
                    result = 1.4 * b;
                    break;

                case "snacks":
                    result = 2 * b;
                    break;
            }

            return result;
        }
    }
}