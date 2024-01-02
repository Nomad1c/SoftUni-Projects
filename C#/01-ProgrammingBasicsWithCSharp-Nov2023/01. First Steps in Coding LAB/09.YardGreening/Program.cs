using System;

namespace YardGreeting
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            double cena = 7.61;
            double discount = 0.18;

            double space = Convert.ToDouble(Console.ReadLine());

            double finalPrice = cena * space;
            double finalDiscount = finalPrice * discount;
            double discountedFinalPrice = finalPrice - finalDiscount;

            Console.WriteLine("The final price is: " + discountedFinalPrice + " lv.");
            Console.WriteLine("The discount is: " + finalDiscount + " lv.");
        }
    }
}