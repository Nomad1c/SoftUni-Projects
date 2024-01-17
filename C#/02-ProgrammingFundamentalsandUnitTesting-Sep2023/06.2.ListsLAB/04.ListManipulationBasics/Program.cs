using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Dereference of a possibly null reference.

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] _)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> inserter = new List<int>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input.Contains("Add"))
                {
                    string removed = input.Remove(input.IndexOf("Add "), 4);
                    int num = int.Parse(removed);
                    list.Add(num);
                }

                else if (input.Contains("RemoveAt"))
                {
                    string removed = input.Remove(input.IndexOf("RemoveAt "), 9);
                    int num = int.Parse(removed);
                    list.RemoveAt(num);
                }

                else if (input.Contains("Remove"))
                {
                    string removed = input.Remove(input.IndexOf("Remove "), 7);
                    int num = int.Parse(removed);
                    list.RemoveAll(item => item == num);
                }

                else if (input.Contains("Insert"))
                {
                    string removed = input.Remove(input.IndexOf("Insert "), 7);
                    inserter = removed
                        .Split(' ')
                        .Select(int.Parse)
                        .ToList();
                    list.Insert(inserter[1], inserter[0]);
                }

                input = Console.ReadLine();
            }

            foreach (int a in list)
            {
                Console.Write($"{a} ");
            }
        }
    }
}