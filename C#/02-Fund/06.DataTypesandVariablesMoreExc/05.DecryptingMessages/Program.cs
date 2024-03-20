using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int key = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            string word = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char a = Convert.ToChar(Console.ReadLine());
                
                for (int j = 0; j < key; j++)
                {
                    a++;
                }
                word += a;
            }

            Console.WriteLine(word);
        }
    }
}