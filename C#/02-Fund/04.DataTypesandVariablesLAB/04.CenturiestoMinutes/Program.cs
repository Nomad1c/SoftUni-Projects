namespace CenturiestoMinutes
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            byte senturies = Convert.ToByte(Console.ReadLine());
            short years = (short)(senturies * 100);
            int days = (int)(years * 365.2422);
            long hours = (long)(days * 24);
            double minutes = (double)(hours * 60);

            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
        }
    }
}