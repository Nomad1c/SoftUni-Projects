using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            //Input
            double masterJohnsFund = Convert.ToDouble(Console.ReadLine());
            double studentAmount = Convert.ToDouble(Console.ReadLine());
            double costSaber = Convert.ToDouble(Console.ReadLine());
            double costRobe = Convert.ToDouble(Console.ReadLine());
            double costBelt = Convert.ToDouble(Console.ReadLine());

            //calc
            double saberForAllStudents = Math.Ceiling(studentAmount * 1.1) * costSaber;
            double robeForAllStudents = studentAmount * costRobe;
            double beltforAllStudents = costBelt * (studentAmount - Math.Floor(studentAmount / 6));

            double totalCost = saberForAllStudents + robeForAllStudents + beltforAllStudents;

            //Output
            if (masterJohnsFund >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }

            else
            {
                double needed = totalCost - masterJohnsFund;
                Console.WriteLine($"John will need {needed:F2}lv more.");
            }
        }
    }
}