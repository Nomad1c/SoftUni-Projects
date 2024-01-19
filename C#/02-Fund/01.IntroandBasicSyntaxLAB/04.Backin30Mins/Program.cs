using System;

namespace Backin30Mins
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int totalMinutes = (a * 60 + b) + 30;

            if (totalMinutes % 1440 == 0)
            {
                int hours = totalMinutes / 60;
                int minutes = totalMinutes % 60;

                TimeSpan timeSpan = new TimeSpan(hours, minutes, 0);
                string formattedTime = $"{timeSpan:hh\\:mm}";

                Console.WriteLine(formattedTime);
            }

            else
            {
                while (totalMinutes % 1440 > 0)
                {
                    totalMinutes -= 1440;
                }

                int hours = totalMinutes / 60;
                int minutes = totalMinutes % 60;

                TimeSpan timeSpan = new TimeSpan(hours, minutes, 0);
                string formattedTime = $"{timeSpan:hh\\:mm}";

                Console.WriteLine(formattedTime);
            }


        }
    }
}