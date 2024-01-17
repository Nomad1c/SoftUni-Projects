using System;

namespace WeekendorWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string a = Console.ReadLine();

            if (a == "Monday" ||  a == "Tuesday" || a == "Wednesday" || a == "Thursday" || a == "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (a == "Saturday" || a == "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}