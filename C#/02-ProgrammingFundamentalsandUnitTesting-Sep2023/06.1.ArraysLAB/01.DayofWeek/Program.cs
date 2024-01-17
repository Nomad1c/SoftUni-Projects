using System;

namespace DayofWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thirsday", "Friday", "Saturday", "Sunday"};

            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(days[n - 1]);
            }

            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}