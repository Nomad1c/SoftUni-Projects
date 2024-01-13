using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string a = Console.ReadLine();

            switch (a)
            {
                case "Monday":
                    Console.WriteLine("12");
                    break;
                case "Tuesday":
                    Console.WriteLine("12");
                    break;
                case "Wednesday":
                    Console.WriteLine("14");
                    break;
                case "Thursday":
                    Console.WriteLine("14");
                    break;
                case "Friday":
                    Console.WriteLine("12");
                    break;
                case "Saturday":
                    Console.WriteLine("16");
                    break;
                case "Sunday":
                    Console.WriteLine("16");
                    break;
            }
        }
    }
}