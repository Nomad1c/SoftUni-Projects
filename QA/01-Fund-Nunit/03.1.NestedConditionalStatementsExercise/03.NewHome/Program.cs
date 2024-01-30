namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosePrice = 5;
            double dahliaPrice = 3.80;
            double tulipPrice = 2.80;
            double narcissusPrice = 3;
            double gladiolusPrice = 2.50;

            double totalCost = 0;

            switch (flowerType)
            {
                case "Roses":
                    totalCost = flowersCount * rosePrice;
                    if (flowersCount > 80)
                    {
                        totalCost *= 0.90;
                    }
                    break;

                case "Dahlias":
                    totalCost = flowersCount * dahliaPrice;
                    if (flowersCount > 90)
                    {
                        totalCost *= 0.85;
                    }
                    break;

                case "Tulips":
                    totalCost = flowersCount * tulipPrice;
                    if (flowersCount > 80)
                    {
                        totalCost *= 0.85;
                    }
                    break;

                case "Narcissus":
                    totalCost = flowersCount * narcissusPrice;
                    if (flowersCount < 120)
                    {
                        totalCost *= 1.15;
                    }
                    break;

                case "Gladiolus":
                    totalCost = flowersCount * gladiolusPrice;
                    if (flowersCount < 80)
                    {
                        totalCost *= 1.20;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid flower type.");
                    return;
            }

            double moneyLeft = budget - totalCost;

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {moneyLeft:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyLeft):F2} leva more.");
            }
        }
    }
}