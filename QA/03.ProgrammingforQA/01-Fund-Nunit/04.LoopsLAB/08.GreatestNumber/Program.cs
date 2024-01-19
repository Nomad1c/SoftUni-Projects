using System;

namespace GreatestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = String.Empty;
            int largestNum = int.MinValue;
            int num = int.MinValue;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Stop")
                {
                    Console.WriteLine(largestNum);
                    break;
                }

                else
                {
                    num = Convert.ToInt32(input);

                    if (num > largestNum)
                    {
                        largestNum = num;
                    }
                }
            }
        }
    }
}