using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int numberAmount = Convert.ToInt32(Console.ReadLine());
            int biggest = int.MinValue;
            int num = 0;
            int sum = 0;

            for (int i = 0; i < numberAmount; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;

                if (num > biggest)
                {
                    biggest = num;
                }
            }

            sum -= biggest;

            if (sum - biggest == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggest}");
            }

            else
            {
                Console.WriteLine("No");
                int diff = Math.Abs(sum - biggest);
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}