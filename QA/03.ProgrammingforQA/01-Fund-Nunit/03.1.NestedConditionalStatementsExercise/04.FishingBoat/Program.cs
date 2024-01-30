namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double springPrice = 3000;
            double summerAutumnPrice = 4200;
            double winterPrice = 2600;

            double baseCost = 0;

            switch (season)
            {
                case "Spring":
                    baseCost = springPrice;
                    break;
                case "Summer":
                case "Autumn":
                    baseCost = summerAutumnPrice;
                    break;
                case "Winter":
                    baseCost = winterPrice;
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    return;
            }

            if (fishermenCount <= 6)
            {
                baseCost *= 0.9;
            }
            else if (fishermenCount <= 11)
            {
                baseCost *= 0.85;
            }
            else
            {
                baseCost *= 0.75;
            }

            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                baseCost *= 0.95;
            }

            double moneyLeft = groupBudget - baseCost;

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):F2} leva.");
            }
        }
    }
}