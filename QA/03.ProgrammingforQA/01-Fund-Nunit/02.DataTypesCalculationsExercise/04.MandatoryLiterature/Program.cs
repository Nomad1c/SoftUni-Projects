using System;

namespace MandatoryLiterature
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int totalPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int totalReadingTime = totalPages / pagesPerHour;
            int hoursPerDay = totalReadingTime / numberOfDays;

            Console.WriteLine(hoursPerDay);
        }
    }
}