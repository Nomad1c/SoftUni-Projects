using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double sum = 0;
            double inserted = 0;
            string input = Console.ReadLine();
            int started = 0;

            if (input != "End")
            {
                while (input != "End")
                {
                    if (started == 0)
                    {
                        if (double.TryParse(input, out inserted))
                        {
                            switch (inserted)
                            {
                                case 0.1:
                                case 0.2:
                                case 0.5:
                                case 1.0:
                                case 2.0:
                                    sum += inserted;
                                    break;
                                default:
                                    Console.WriteLine($"Cannot accept {inserted}");
                                    break;
                            }
                        }

                        else if (input == "Start")
                        {
                            started++;
                            continue;
                        }
                    }

                    else if (started == 1)
                    {
                        if (input == "Start")
                        {
                            switch (input)
                            {
                                case "Nuts":
                                    if (sum - 2 >= 0)
                                    {
                                        sum -= 2;
                                        Console.WriteLine("Purchased nuts");
                                    }
                                    
                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }

                                    break;
                                case "Water":
                                    if (sum - 0.7 >= 0)
                                    {
                                        sum -= 0.7;
                                        Console.WriteLine("Purchased water");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }

                                    break;
                                case "Crisps":
                                    if (sum - 1.5 >= 0)
                                    {
                                        sum -= 1.5;
                                        Console.WriteLine("Purchased chrisps");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }

                                    break;
                                case "Soda":
                                    if (sum - 0.8 >= 0)
                                    {
                                        sum -= 0.8;
                                        Console.WriteLine("Purchased soda");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }

                                    break;
                                case "Coke":
                                    if (sum - 1 >= 0)
                                    {
                                        sum -= 1;
                                        Console.WriteLine("Purchased coke");
                                    }

                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }

                                    break;

                                default:
                                    if (input != "Start")
                                    {
                                        Console.WriteLine("Invalid product");
                                    }
                                    break;
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine($"Cannot accept {input}");
                    }
                    
                    input = Console.ReadLine();
                }
            }

            else
            {
                Console.WriteLine($"Change: {sum:F2}");
            }
        }
    }
}