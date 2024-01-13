using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double ppl = Convert.ToDouble(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double total = 0;

            switch (day)
            {
                case "Friday":
                    {
                        switch (group)
                        {
                            case "Students":
                                {
                                    total = ppl * 8.45;
                                    if (ppl >= 30)
                                    {
                                        total *= 0.85;
                                    }
                                } break;

                            case "Business":
                                {
                                    total = ppl * 10.9;
                                    if (ppl >= 100)
                                    {
                                        total -= 109;
                                    }
                                } break;

                            case "Regular":
                                {
                                    total = ppl * 15;
                                    if (ppl >= 10 && ppl <= 20)
                                    {
                                        total *= 0.95;
                                    }
                                } break;
                        }
                    } break;

                case "Saturday":
                    {
                        switch (group)
                        {
                            case "Students":
                                {
                                    total = ppl * 9.8;
                                    if (ppl >= 30)
                                    {
                                        total *= 0.85;
                                    }
                                }
                                break;

                            case "Business":
                                {
                                    total = ppl * 15.6;
                                    if (ppl >= 100)
                                    {
                                        total -= 156;
                                    }
                                }
                                break;

                            case "Regular":
                                {
                                    total = ppl * 20;
                                    if (ppl >= 10 && ppl <= 20)
                                    {
                                        total *= 0.95;
                                    }
                                }
                                break;
                        }
                    } break;

                case "Sunday":
                    {
                        switch (group)
                        {
                            case "Students":
                                {
                                    total = ppl * 10.46;
                                    if (ppl >= 30)
                                    {
                                        total *= 0.85;
                                    }
                                }
                                break;

                            case "Business":
                                {
                                    total = ppl * 20;
                                    if (ppl >= 100)
                                    {
                                        total -= 200;
                                    }
                                }
                                break;

                            case "Regular":
                                {
                                    total = ppl * 22.5;
                                    if (ppl >= 10 && ppl <= 20)
                                    {
                                        total *= 0.95;
                                    }
                                }
                                break;
                        }
                    } break;
            }

            Console.WriteLine($"Total price: {total:F2}");
        }
    }
}