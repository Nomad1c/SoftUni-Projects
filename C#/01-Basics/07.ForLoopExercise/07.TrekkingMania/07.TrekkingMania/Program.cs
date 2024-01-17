using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] _)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double numberofGroups = Convert.ToDouble(Console.ReadLine());
            double groupSize = 0;
            double totalMembers = 0;
            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;
            double res1 = 0;
            double res2 = 0;
            double res3 = 0;
            double res4 = 0;
            double res5 = 0;

            for (int i = 0;  i < numberofGroups; i++)
            {
                groupSize = Convert.ToDouble(Console.ReadLine());
                totalMembers += groupSize;

                if (groupSize <= 5)
                {
                    group1 += groupSize;
                }
                else if (groupSize > 5 && groupSize <= 12)
                {
                    group2 += groupSize;

                }
                else if (groupSize > 12 && groupSize <= 25)
                {
                    group3 += groupSize;

                }
                else if (groupSize > 25 &&  groupSize <= 40)
                {
                    group4 += groupSize;

                }
                else if (groupSize > 40)
                {
                    group5 += groupSize;

                }
            }

            res1 = group1 / totalMembers * 100;
            res2 = group2 / totalMembers * 100;
            res3 = group3 / totalMembers * 100;
            res4 = group4 / totalMembers * 100;
            res5 = group5 / totalMembers * 100;

            Console.WriteLine($"{res1:F2}%");
            Console.WriteLine($"{res2:F2}%");
            Console.WriteLine($"{res3:F2}%");
            Console.WriteLine($"{res4:F2}%");
            Console.WriteLine($"{res5:F2}%");
        }
    }
}