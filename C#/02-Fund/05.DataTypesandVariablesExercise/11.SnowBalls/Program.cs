using System;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            double winner = 0.0;
            int a = 0; int b = 0; double c = 0; int d = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = Convert.ToInt32(Console.ReadLine());
                int snowballTime = Convert.ToInt32(Console.ReadLine());
                int snowballQuality = Convert.ToInt32(Console.ReadLine());

                double snowballValue = Math.Pow((double)(snowballSnow / snowballTime), (double)snowballQuality);
                
                if (snowballValue > winner)
                {
                    winner = snowballValue;
                    a = snowballSnow;
                    b = snowballTime;
                    c = snowballValue;
                    d = snowballQuality;
                }
            }

            Console.WriteLine($@"{a} : {b} = {c} ({d})");
        }
    }
}