using System;

namespace CatFood
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int pisita = Convert.ToInt32(Console.ReadLine());
            double grams = 0;
            double totalGrams = 0;
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            double total = 0;

            for (int i = 0; i < pisita; i++)
            {
                grams = Convert.ToDouble(Console.ReadLine());
                totalGrams += grams;

                if (grams >= 100 && grams < 200)
                {
                    group1++;
                }
                else if (grams >= 200 && grams < 300)
                {
                    group2++;
                }
                else if (grams >= 300 && grams < 400)
                {
                    group3++;
                }
            }

            total = totalGrams * 0.01245;

            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {total:F2} lv.");
        }
    }
}