using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            /* Кинозала
             * столове наредени правоъгълно
             * r реда, c колони
             * 3 вида прожекции с различни цени
             * Premiere - 12.00лв
             * Normal - 7.50лв
             * Discount - 5.00лв
             * ----------------
             * Цел: да чете тип прожекция (string)
             * брой редове и колони (int)
             * да изчисли общите приходи от билети при пълна зала
             * "{format:F2} leva"
             */

            //input
            string type = Console.ReadLine();
            int r = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            double income = 0;

            //calc
            if (type == "Premiere")
            {
                income = 12 * r * c;
                Console.WriteLine($"{income:F2} leva");
            }
            else if (type == "Normal")
            {
                income = 7.5 * r * c;
                Console.WriteLine($"{income:F2} leva");
            }
            else if (type == "Discount")
            {
                income = 5 * r * c;
                Console.WriteLine($"{income:F2} leva");
            }
        }
    }
}