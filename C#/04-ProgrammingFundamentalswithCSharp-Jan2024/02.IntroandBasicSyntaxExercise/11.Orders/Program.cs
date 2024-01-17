using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
             int ordersCount = int.Parse(Console.ReadLine());
             double totalPrice = 0;

             for (int i = 0; i < ordersCount; i++)
             {
                 double pricePerCapsule = double.Parse(Console.ReadLine());
                 int days = int.Parse(Console.ReadLine());
                 int capsulesCount = int.Parse(Console.ReadLine());

                 double orderPrice = CalculateOrderPrice(pricePerCapsule, days, capsulesCount);
                 Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
                 totalPrice += orderPrice;
             }

             Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        static double CalculateOrderPrice(double pricePerCapsule, int days, int capsulesCount)
        {
            double orderPrice = (days * capsulesCount) * pricePerCapsule;
            return orderPrice;
        }
    }
}