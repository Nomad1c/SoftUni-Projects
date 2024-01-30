using System;

namespace RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            List<int> nums = new List<int>();
            string theListOfNumsInputed = Console.ReadLine();
            nums = theListOfNumsInputed.Split(' ').Select(int.Parse).ToList();

            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i);
                }
            }

            if (nums.Count > 0)
            {
                for (int j = nums.Count - 1; j >= 0; j--)
                {
                    Console.Write($"{nums[j]} ");
                }
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}