using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double inserted = 0;
            string input = Console.ReadLine();
            int started = 0;

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
                    }
                }
                else if (started == 1)
                {
                    switch (input)
                    {
                        case "Nuts":
                            PurchaseProduct("nuts", 2, ref sum);
                            break;
                        case "Water":
                            PurchaseProduct("water", 0.7, ref sum);
                            break;
                        case "Crisps":
                            PurchaseProduct("crisps", 1.5, ref sum);
                            break;
                        case "Soda":
                            PurchaseProduct("soda", 0.8, ref sum);
                            break;
                        case "Coke":
                            PurchaseProduct("coke", 1, ref sum);
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:F2}");
        }

        static void PurchaseProduct(string productName, double price, ref double sum)
        {
            if (sum - price >= 0)
            {
                sum -= price;
                Console.WriteLine($"Purchased {productName}");
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money for {productName}");
            }
        }
    }
}
