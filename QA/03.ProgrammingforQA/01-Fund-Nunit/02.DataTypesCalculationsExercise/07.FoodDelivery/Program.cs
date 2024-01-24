using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenus * 10.35;
            double fishMenuPrice = fishMenus * 12.40;
            double vegetarianMenuPrice = vegetarianMenus * 8.15;

            double totalMenuCost = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice;

            double dessertPrice = totalMenuCost * 0.20;
            double deliveryPrice = 2.50;

            double totalOrderPrice = totalMenuCost + dessertPrice + deliveryPrice;

            Console.WriteLine(totalOrderPrice);
        }
    }
}
