using System;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());

            MagicNumbers(N);
        }

        static int MagicNumbers(int a)
        {
            int x, y, z, result;

            for (int i = 100; i <= 999; i++)
            {
                string number = Convert.ToString(i);

                x = Convert.ToInt32(number.Substring(0, 1));
                y = Convert.ToInt32(number.Substring(1, 1));
                z = Convert.ToInt32(number.Substring(2, 1));

                if (x * y * z == a)
                {
                    result = Convert.ToInt32(($"{x}{y}{z}"));
                    Console.Write(result + " ");
                }
            }

            return 0;
        }
    }
}