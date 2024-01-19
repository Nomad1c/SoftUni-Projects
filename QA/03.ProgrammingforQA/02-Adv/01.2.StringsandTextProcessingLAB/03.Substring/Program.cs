using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            //int index = 0;
            
            while (text.Contains(wordToRemove))
            {
                //index = text.IndexOf(wordToRemove);
                //text = text.Remove(index, wordToRemove.Length);
                text = text.Replace(wordToRemove, "");
            }

            Console.WriteLine(text);
        }
    }
}