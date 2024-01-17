using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string name = Console.ReadLine();
            double points = Convert.ToDouble(Console.ReadLine());
            int ppl = Convert.ToInt32(Console.ReadLine());
            string actor = "";
            double pointsPA = 0;
            double stringLenght = 0;

            for (int i = 0; i < ppl; i++)
            {
                actor = Console.ReadLine();
                pointsPA = Convert.ToDouble(Console.ReadLine());
                stringLenght = Convert.ToDouble(actor.Length);
                points = points + (stringLenght * pointsPA / 2);

                if (points > 1250.5) { break; }
            }

            if (points > 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {points:F1}!");
            }

            else
            {
                points = 1250.5 - points;
                Console.WriteLine($"Sorry, {name} you need {points:F1} more!");
            }
        }
    }
}