namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if (nightsCount > 14)
                    {
                        studioPrice *= 0.7;
                        apartmentPrice *= 0.9;
                    }
                    else if (nightsCount > 7)
                    {
                        studioPrice *= 0.95;
                    }
                    break;

                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (nightsCount > 14)
                    {
                        studioPrice *= 0.8;
                        apartmentPrice *= 0.9;
                    }
                    break;

                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    if (nightsCount > 14)
                    {
                        apartmentPrice *= 0.9;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid month.");
                    return;
            }

            double totalStudioCost = studioPrice * nightsCount;
            double totalApartmentCost = apartmentPrice * nightsCount;

            Console.WriteLine($"Apartment: {totalApartmentCost:F2} lv.");
            Console.WriteLine($"Studio: {totalStudioCost:F2} lv.");
        }
    }
}