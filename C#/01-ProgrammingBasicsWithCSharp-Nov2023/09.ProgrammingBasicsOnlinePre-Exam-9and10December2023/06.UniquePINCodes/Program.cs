using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] _)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            //1: четно
            //2: [2-7]
            //3: четно

            int maxA = Convert.ToInt32(Console.ReadLine());
            int maxB = Convert.ToInt32(Console.ReadLine());
            int maxC = Convert.ToInt32(Console.ReadLine());
            int a = 2; int b = 2; int c = 2; int num = 0;
            int max = maxA * 100 + maxB * 10 + maxC;
            int x = 0; int y = 0; int z = 0;
            string numS = String.Empty;

            while (num < 1000)
            {
                num = a * 100 + b * 10 + c;
                numS = Convert.ToString(num);

                x = Convert.ToInt32(numS.Substring(0, 1));
                y = Convert.ToInt32(numS.Substring(1, 1));
                z = Convert.ToInt32(numS.Substring(2, 1));

                if (x > maxA && y > maxB && z > maxC)
                {
                    break;
                }


                if (c >= 10 || c > maxC)
                {
                    c -= 10;
                    b++;

                    if (b >= 10 || c > maxB)
                    {
                        b -= 10;
                        a++;

                        if (a>= 10 || a > maxA)
                        {
                            break;
                        }
                    }
                }

                if (a > 0 && b >= 2 && b <= 7 && a % 2 == 0 && c % 2 == 0 && c > 0)
                {
                    if (a <= maxA && b <= maxB && c <= maxC)
                    {
                        if (b != 4 && b != 6)
                        {
                            Console.WriteLine($"{a} {b} {c}");
                        }
                    }
                }

                c++;
            }




        }
    }
}