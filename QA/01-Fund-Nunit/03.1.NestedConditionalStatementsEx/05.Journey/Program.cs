namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            const double BulgariaThreshold = 100;
            const double BalkansThreshold = 1000;

            const double BulgariaSummerPercentage = 0.3;
            const double BulgariaWinterPercentage = 0.7;
            const double BalkansSummerPercentage = 0.4;
            const double BalkansWinterPercentage = 0.8;
            const double EuropePercentage = 0.9;

            string destination = "";
            string holidayType = "";
            double amountSpent = 0;

            if (budget <= BulgariaThreshold)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    amountSpent = budget * BulgariaSummerPercentage;
                }
                else if (season == "winter")
                {
                    holidayType = "Hotel";
                    amountSpent = budget * BulgariaWinterPercentage;
                }
            }
            else if (budget <= BalkansThreshold)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    amountSpent = budget * BalkansSummerPercentage;
                }
                else if (season == "winter")
                {
                    holidayType = "Hotel";
                    amountSpent = budget * BalkansWinterPercentage;
                }
            }
            else
            {
                destination = "Europe";
                holidayType = "Hotel";
                amountSpent = budget * EuropePercentage;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {amountSpent:F2}");
        }
    }
}