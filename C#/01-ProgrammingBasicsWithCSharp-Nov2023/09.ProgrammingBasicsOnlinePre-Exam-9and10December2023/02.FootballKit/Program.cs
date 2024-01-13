using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            /*
             * Тениски, шорти, чорапи и бутонки
             * Цена шорти = 75% от цената на тениските,
             * цена чорапи = 20% от цената на шортите.
             * Цена бутонки = 2Х от цената на (тениските + шортите).
             * Отстъпка 15%.
             * ако цената е >= от дадена сума - подарък топка световно.
             * ---
             * дали пепи получава топка.
             * ---
             * - цена на тениска
             * - сума за топка
            */

            double shirtPrice = Convert.ToDouble(Console.ReadLine());
            double priceGoal = Convert.ToDouble(Console.ReadLine());
            double total = 0;
            double shortPrice = 0;
            double sockPrice = 0;
            double shoePrice = 0;

            shortPrice = shirtPrice * 0.75;
            sockPrice = 0.2 * shortPrice;
            shoePrice = 2 * (shirtPrice + shortPrice);

            total = 0.85 * (shirtPrice + shortPrice + sockPrice + shoePrice);

            if (total >= priceGoal)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:F2} lv.");
            }

            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                priceGoal -= total;
                Console.WriteLine($"He needs {priceGoal:F2} lv. more.");
            }
        }
    }
}