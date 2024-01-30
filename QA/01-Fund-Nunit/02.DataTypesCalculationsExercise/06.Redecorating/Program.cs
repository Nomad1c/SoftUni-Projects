using System;

namespace Redecorating
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int nylonSqMeters = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int hoursOfWork = int.Parse(Console.ReadLine());

            double nylonCost = (nylonSqMeters + 2) * 1.50;
            double paintCost = (paintLiters + (paintLiters * 0.10)) * 14.50;
            double thinnerCost = thinnerLiters * 5.00;
            double bagsCost = 0.40;

            double totalMaterialCost = nylonCost + paintCost + thinnerCost + bagsCost;

            double craftsmenCost = (totalMaterialCost * 0.30) * hoursOfWork;

            double totalCost = totalMaterialCost + craftsmenCost;

            Console.WriteLine(totalCost);
        }
    }
}
