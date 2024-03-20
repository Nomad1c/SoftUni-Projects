using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            bool search = false;

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                if (text == "(")
                {
                    search = true;
                }

                if (text == ")" && search == true)
                {
                    search = false;
                }

            }

            if (search == false)
            {
                Console.WriteLine("BALANCED");
            }

            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}