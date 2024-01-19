using System;
using System.Diagnostics.Metrics;

namespace LetterCombinations
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            char s = Convert.ToChar(Console.ReadLine());
            Char e = Convert.ToChar(Console.ReadLine());
            char x = Convert.ToChar(Console.ReadLine());

            Combinator(s, e, x);
        }

        static char Combinator(char a, char b, char c)
        {
            int counter = 0;
            string phrase = String.Empty;

            for (char letter1 = a; letter1 <= b; letter1++)
            {
                if (letter1 == c) { continue; }

                else
                {
                    for (char letter2 = a; letter2 <= b; letter2++)
                    {
                        if (letter2 == c) { continue; }

                        else
                        {
                            for (char letter3 = a; letter3 <= b; letter3++)
                            {
                                if (letter3 == c) { continue; }

                                else
                                {
                                    Console.Write($"{letter1}{letter2}{letter3} ");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(counter);

            return (char)0;
        }
    }
}