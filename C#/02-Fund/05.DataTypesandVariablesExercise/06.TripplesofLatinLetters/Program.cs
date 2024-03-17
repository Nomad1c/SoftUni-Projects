using System;

namespace TripplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char one = (char)('a' + i);
                
                for (int j = 0; j < n; j++)
                {
                    char two = (char)('a' + j);

                    for (int k = 0; k < n; k++)
                    {
                        char tre = (char)('a' + k);

                        string sum = ($@"{one}{two}{tre}");

                        Console.WriteLine(sum);
                    }
                }
            }
        }
    }
}