using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int pokePower = Convert.ToInt32(Console.ReadLine());
            int distance = Convert.ToInt32(Console.ReadLine());
            int exhaustionFactor = Convert.ToInt32(Console.ReadLine());

            int Poked = 0;
            double originalPokePower = (double)pokePower;

            while (pokePower >= distance)
            {
                Poked++;
                pokePower -= distance;

                if (pokePower == Math.Floor(originalPokePower / 2.0))
                {
                    if (pokePower % exhaustionFactor == 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(Poked);
        }
    }
}