namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double worldRecordInSeconds = Convert.ToDouble(Console.ReadLine());
            double metersToSwim = Convert.ToDouble(Console.ReadLine());
            double secondsPerOneMeter = Convert.ToDouble(Console.ReadLine());

            // Calculations
            double slowingDueToDrag = Math.Floor(metersToSwim / 15.0) * 12.5;
            double totalTime = metersToSwim * secondsPerOneMeter + slowingDueToDrag;

            // Output
            if (totalTime < worldRecordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                double timeDifference = totalTime - worldRecordInSeconds;
                Console.WriteLine($"No, he failed! He was {timeDifference:F2} seconds slower.");
            }
        }
    }
}
