using System;

namespace SumanArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int sum = 0;

            foreach (string num in inputArray)
            {
                sum += int.Parse(num);
            }

            Console.WriteLine(sum);
        }
    }
}