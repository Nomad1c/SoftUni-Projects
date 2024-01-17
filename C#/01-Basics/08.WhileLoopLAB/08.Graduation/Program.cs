using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string name = Console.ReadLine();
            double grade = 0;
            double year = 1;
            double fails = 0;
            double total = 0;

            while (fails <= 1)
            {
                grade = Convert.ToDouble(Console.ReadLine());
                total += grade;

                if (grade < 4)
                {
                    total -= grade;
                    fails++;
                    year--;
                }

                if (year == 12) { break; }

                year++;
            }
            
            if (fails > 1)
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");
            }
            else
            {
                total = total / (fails + year);
                Console.WriteLine($"{name} graduated. Average grade: {total:F2}");
            }
        }
    }
}