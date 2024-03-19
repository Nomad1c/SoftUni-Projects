using System;

namespace FromLefttotheRight
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string nums = Console.ReadLine();
                List<double> list = new List<double>();
                int sum = 0;

                list = nums.Split(' ').Select(double.Parse).ToList();

                if (list[0] > list[1])
                {
                    string String = Convert.ToString(list[0]);

                    for (int j = 0; j < String.Length; j++)
                    {
                        sum += Convert.ToInt32(String.Substring(j, 1));
                    }

                    Console.WriteLine(sum);
                    sum = 0;
                }

                else
                {
                    string String = Convert.ToString(list[1]);

                    for (int j = 0; j < String.Length; j++)
                    {
                        sum += Convert.ToInt32(String.Substring(j, 1));
                    }

                    Console.WriteLine(sum);
                    sum = 0;
                }
            }
        }
    }
}