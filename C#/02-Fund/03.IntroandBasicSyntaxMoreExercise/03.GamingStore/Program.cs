using System;

namespace GamingSore
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;

            while (true)
            {
                string game = Console.ReadLine();

                if (game == "Game Time")
                {
                    break;
                }

                switch (game)
                {
                    case "OutFall 4":
                        if (balance >= 39.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 39.99;
                            totalSpent += 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (balance >= 15.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 15.99;
                            totalSpent += 15.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance >= 19.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 19.99;
                            totalSpent += 19.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (balance >= 59.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 59.99;
                            totalSpent += 59.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (balance >= 29.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 29.99;
                            totalSpent += 29.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance >= 39.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            balance -= 39.99;
                            totalSpent += 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");

        }
    }
}