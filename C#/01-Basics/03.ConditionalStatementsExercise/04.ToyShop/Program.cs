using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = Convert.ToDouble(Console.ReadLine());
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int a4 = Convert.ToInt32(Console.ReadLine());
            int a5 = Convert.ToInt32(Console.ReadLine());

            double totalAmount = a1 * 2.60 + a2 * 3 + a3 * 4.10 + a4 * 8.20 + a5 * 2;

            if (a1 + a2 + a3 + a4 + a5 >= 50)
            {
                totalAmount *= 0.75; // Apply the 25% discount
            }

            totalAmount *= 0.9; // Subtract the rent

            if (totalAmount >= vacationPrice)
            {
                double left = totalAmount - vacationPrice;
                string formattedNumber = left.ToString("0.00");
                Console.WriteLine($"Yes! {formattedNumber} lv left.");
            }
            else
            {
                double needed = vacationPrice - totalAmount;
                string formattedNumber = needed.ToString("0.00");
                Console.WriteLine($"Not enough money! {formattedNumber} lv needed.");
            }
        }
    }
}
