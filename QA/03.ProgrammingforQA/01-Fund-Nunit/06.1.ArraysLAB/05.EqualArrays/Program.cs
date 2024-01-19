using System;
using System.Linq;

namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the first array from user input
            string[] arr1 = Console.ReadLine().Split(' ');

            // Read the second array from user input
            string[] arr2 = Console.ReadLine().Split(' ');

            // Compare arrays based on their content
            if (arr1.SequenceEqual(arr2))
            {
                Console.WriteLine("Arrays are identical.");
            }
            else
            {
                Console.WriteLine("Arrays are not identical.");
            }
        }

    }
}