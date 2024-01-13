using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] _)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double tournamentNumber = Convert.ToDouble(Console.ReadLine());
            double currentPoints = Convert.ToDouble(Console.ReadLine());
            string game = "0";
            double pointsWon = 0;
            double w = 0;

            for (int i = 0; i < tournamentNumber; i++)
            {
                game = Console.ReadLine();
                
                switch (game)
                {
                    case "W":
                        currentPoints += 2000;
                        pointsWon += 2000;
                        w++;
                        break;

                    case "F":
                        currentPoints += 1200;
                        pointsWon += 1200;
                        break;

                    case "SF":
                        currentPoints += 720;
                        pointsWon += 720;
                        break;
                }
            }

            Console.WriteLine($"Final points: {currentPoints}");

            int averagePoints = Convert.ToInt32(Math.Floor(pointsWon / tournamentNumber));
            Console.WriteLine($"Average points: {averagePoints}");

            w = w / tournamentNumber * 100;
            Console.WriteLine($"{w:F2}%");
        }
    }
}