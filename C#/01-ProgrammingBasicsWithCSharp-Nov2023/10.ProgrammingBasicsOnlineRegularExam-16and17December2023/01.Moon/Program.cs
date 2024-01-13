using System;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double speed = Convert.ToDouble(Console.ReadLine());
            double litrePer100km = Convert.ToDouble(Console.ReadLine());

            double hours = 384400 / speed;
            hours += hours;
            hours += 3;
            hours = Math.Ceiling(hours);

            double litre = litrePer100km * 2 * 3844;

            Console.WriteLine(hours);
            Console.WriteLine(litre);
        }
    }
}