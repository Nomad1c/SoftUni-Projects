using System;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int a = a1 * 60;
            int c = a + b + 15;

            int hours = c / 60;
            int minutes = c % 60;

            if (hours >= 24)
            {
                hours -= 24;

                if (minutes < 10)
                {
                    Console.WriteLine(hours + ":0" + minutes);
                }
                else
                {
                    Console.WriteLine(hours + ":" + minutes);
                }
            }
            else
            {
                if (minutes < 10)
                {
                    Console.WriteLine(hours + ":0" + minutes);
                }
                else
                {
                    Console.WriteLine(hours + ":" + minutes);
                }
            }
        }
    }
}