using System;

namespace DayofWeek
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Monday");
            }
            if (a == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (a == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (a == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (a == 5)
            {
                Console.WriteLine("Friday");
            }
            if (a == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (a == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (a < 1 || a > 7)
            {
                Console.WriteLine("Error");
            }
        }
    }
}