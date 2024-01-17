using System;

namespace ReverseanArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int initial = Convert.ToInt32(Console.ReadLine());
            string[] nums = new string[initial];

            for (int i = 0; i < initial; i++)
            {
                nums[i] = Console.ReadLine() + " ";
            }

            for (int j = 1; j <= nums.Length; j++)
            {
                Console.Write(nums[initial - j]);
            }
        }
    }
}