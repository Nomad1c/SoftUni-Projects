using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Repeater(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(result);
        }

        static string Repeater(string a, int b)
        {
            string text = String.Empty;

            for (int i = 0; i < b; i++)
            {
                text += a;
            }
            
            return text;
        }
    }
}