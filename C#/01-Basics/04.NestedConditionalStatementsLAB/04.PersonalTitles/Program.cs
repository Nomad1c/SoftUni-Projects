using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double age = Convert.ToDouble(Console.ReadLine());
            string sex = Console.ReadLine();

            switch (sex)
            {
                case "m":
                    if (age < 16)
                    {
                        Console.WriteLine("Master");
                    }
                    else
                    {
                        Console.WriteLine("Mr.");
                    }
                    break;
                case "f":
                    if (age < 16)
                    {
                        Console.WriteLine("Miss");
                    }
                    else
                    {
                        Console.WriteLine("Ms.");
                    }
                    break;
            }
        }
    }
}