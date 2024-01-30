using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int trainingFee = int.Parse(Console.ReadLine());

            double sneakersPrice = trainingFee - (0.4 * trainingFee);
            double teamPrice = sneakersPrice - (0.2 * sneakersPrice);
            double basketballPrice = teamPrice / 4;
            double accessoriesPrice = basketballPrice / 5;

            double totalExpense = trainingFee + sneakersPrice + teamPrice + basketballPrice + accessoriesPrice;

            Console.WriteLine(totalExpense);
        }
    }
}
