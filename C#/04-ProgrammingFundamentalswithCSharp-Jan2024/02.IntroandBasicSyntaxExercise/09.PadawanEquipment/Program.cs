using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double johnMoney = Convert.ToDouble(Console.ReadLine());
            int studentNumint = Convert.ToInt32(Console.ReadLine());
            double saberCost = Convert.ToDouble(Console.ReadLine());
            double robeCost = Convert.ToDouble(Console.ReadLine());
            double beltCost = Convert.ToDouble(Console.ReadLine());

            double placeholder = Convert.ToDouble(studentNumint);

            placeholder = Math.Ceiling(placeholder * 1.1);

            studentNumint = Convert.ToInt32(placeholder);
            
            double totalCost = studentNumint * (saberCost + robeCost + beltCost);

            if (johnMoney >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                double needed = johnMoney - totalCost;
                Console.WriteLine($"John will need {needed:F2}lv more.");
            }
        }
    }
}