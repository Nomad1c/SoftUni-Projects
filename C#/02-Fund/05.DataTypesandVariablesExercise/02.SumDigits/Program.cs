using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string a = Console.ReadLine();
            int sum = 0;

            List<int> list = new List<int>();

            list = a.Split("").Select(int.Parse).ToList();

            foreach (int i in list)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
