using System;

namespace SmallestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = String.Empty;
            int smallestNum = int.MaxValue;
            int num = int.MaxValue;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Stop")
                {
                    Console.WriteLine(smallestNum);
                    break;
                }

                else
                {
                    num = Convert.ToInt32(input);

                    if (num < smallestNum)
                    {
                        smallestNum = num;
                    }
                }
            }
        }
    }
}