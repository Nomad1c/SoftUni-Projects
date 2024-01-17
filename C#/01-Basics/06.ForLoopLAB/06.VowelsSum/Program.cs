using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string input = Console.ReadLine();
            char letter;
            int total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                letter = input[i];

                switch (letter)
                {
                    case 'a':
                        total += 1;
                        break;

                    case 'e':
                        total += 2;
                        break;

                    case 'i':
                        total += 3;
                        break;

                    case 'o':
                        total += 4;
                        break;

                    case 'u':
                        total += 5;
                        break;
                }
            }

            Console.WriteLine(total);
        }
    }
}