using System;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            string[] words = Console.ReadLine().Split(); //By default .split() splits the word with a sapce " ", so it is the same as .split(" "), you can also add anything else as a splitter.
                                                         //Input - "hi abc add"
            string result = String.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    result += currentWord;
                }
            }
            Console.WriteLine(result); //Prints "kikiabcabcabcaddaddadd"
        }
    }
}