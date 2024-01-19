using System;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int sum = numbers[i] + numbers[numbers.Length - 1 - i];
                Console.Write(sum + " ");
            }

            if (numbers.Length % 2 != 0)
            {
                Console.Write(numbers[numbers.Length / 2]);
            }

            Console.WriteLine();
        }
    }
}