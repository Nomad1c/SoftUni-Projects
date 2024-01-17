using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CommonElements
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //This line of code performs the following operations in sequence:
            //Console.ReadLine(): Reads a line of text from the console(user input).
            //.Split(' '): Splits the obtained string into an array of substrings using space (' ') as the delimiter.This results in an array of strings
            //.Select(int.Parse): Applies the int.Parse function to each element of the array of strings.This function converts each string representation of an integer into an actual integer.The Select method transforms each string element in the array into its corresponding integer.
            //.ToArray(): Converts the resulting sequence of integers into an array of integers.
            //
            //So, in summary, this line reads a line of space-separated integers from the console, processes it, and stores the resulting array of integers in the variable arr1.The user is expected to input integers separated by spaces, and the code parses them into an array of integers for further use in the program.
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Find and print common elements
            int[] commonElements = arr1.Intersect(arr2).ToArray();

            if (commonElements.Length > 0)
            {
                Console.WriteLine(string.Join(" ", commonElements));
            }
            else
            {
                Console.WriteLine("No common elements.");
            }
        }
    }
}