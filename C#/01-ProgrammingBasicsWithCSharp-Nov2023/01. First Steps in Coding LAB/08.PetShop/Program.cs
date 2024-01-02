using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            double dogPrice = 2.5;
            double catPrice = 4;

            int dog = Convert.ToInt32(Console.ReadLine());
            int cat = Convert.ToInt32(Console.ReadLine());

            double total = dog * dogPrice + catPrice * cat;
            Console.WriteLine(total + " lv.");
        }
    }
}