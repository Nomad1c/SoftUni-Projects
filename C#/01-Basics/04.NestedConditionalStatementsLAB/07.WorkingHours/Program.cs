using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int time = Convert.ToInt32(Console.ReadLine());
            string day = Console.ReadLine();

            if (time >= 10 && time <= 18)
            {
                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("open");
                        break;
                    case "Tuesday":
                        Console.WriteLine("open");
                        break;
                    case "Wednesday":
                        Console.WriteLine("open");
                        break;
                    case "Thursday":
                        Console.WriteLine("open");
                        break;
                    case "Friday":
                        Console.WriteLine("open");
                        break;
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    case "Sunday":
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}