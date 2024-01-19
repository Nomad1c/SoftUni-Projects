using System;
using System.ComponentModel;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            //Write a program that:
            //•	Read a text(string) from the console
            //•	Create a method that receives a text
            //•	Find the count of the vowels contained in the text
            //•	Print the count of the vowels in the text
            //Example Input / Output
            //Input Output
            //SoftUni 3
            //Cats    1
            //JS  0

            string text = Console.ReadLine();

            int result = VowelCounter(text);
            Console.WriteLine(result);
        }

        static int VowelCounter(string text)
        {
            int counter = 0;
            char letter = Char.MinValue;

            for (int i = 0; i < text.Length; i++)
            {
                letter = text[i];

                if ("aeiou".Contains(char.ToLower(letter)))
                {
                    counter++;
                }

            }

            return counter;
        }
    }
}