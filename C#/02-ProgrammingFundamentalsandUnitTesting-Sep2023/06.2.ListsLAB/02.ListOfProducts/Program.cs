using System;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            string input = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                input = Console.ReadLine();
                list.Add($"{i}.{input}");
            }

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

        }
    }
}