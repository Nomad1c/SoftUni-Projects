using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            /*
             * water tank capacity = 255 liters
             * ---
             * INPUT 1 = n
             * INPUT 2 = liters of water to pour into the tank
             * if capacity not enough - "Insufficient capacity!"
             * and continue reading next line
             * on the lat line print the liters in the tank
             */

            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = Convert.ToInt32(Console.ReadLine());

                if (sum + liters <= 255)
                {
                    sum += liters;
                }

                else
                {
                    Console.WriteLine(@"Insufficient capacity!");
                }
            }

            Console.WriteLine(sum);
        }
    }
}