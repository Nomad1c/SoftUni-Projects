using System;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input.Contains("Contains"))
                {
                    string theRest = input.Remove(0, 9);
                    int num = int.Parse(theRest);

                    if (list.Contains(num))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (input.Contains("PrintEven"))
                {
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        if (list[i] % 2 == 0)
                        {
                            Console.Write($"{list[i]} ");
                        }
                    }
                    Console.WriteLine();
                }

                else if (input.Contains("PrintOdd"))
                {
                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        if (list[i] % 2 == 1)
                        {
                            Console.Write($"{list[i]} ");
                        }
                    }
                    Console.WriteLine();
                }

                else if (input.Contains("GetSum"))
                {
                    int sum = 0;
                    
                    for (int i = list.Count - 1;i >= 0; i--)
                    {
                        sum += list[i];
                    }

                    Console.WriteLine(sum);
                }

                else if (input.Contains("Filter"))
                {
                    string theRest = input.Remove(0, 7);

                    if (theRest.Contains("<"))
                    {
                        string allTheRest = theRest.Remove(0, 2);
                        int num = Convert.ToInt32(allTheRest);

                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            if (list[i] < num)
                            {
                                Console.Write($"{list[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (theRest.Contains(">"))
                    {
                        string allTheRest = theRest.Remove(0, 2);
                        int num = Convert.ToInt32(allTheRest);

                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            if (list[i] > num)
                            {
                                Console.Write($"{list[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (theRest.Contains("<="))
                    {
                        string allTheRest = theRest.Remove(0, 3);
                        int num = Convert.ToInt32(allTheRest);

                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            if (list[i] <= num)
                            {
                                Console.Write($"{list[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }

                    else if (theRest.Contains(">="))
                    {
                        string allTheRest = theRest.Remove(0, 3);
                        int num = Convert.ToInt32(allTheRest);

                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            if (list[i] >= num)
                            {
                                Console.Write($"{list[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}