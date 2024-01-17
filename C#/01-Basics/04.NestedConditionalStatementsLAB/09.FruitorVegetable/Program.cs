using System;

namespace FruitorVegetable
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            string name = Console.ReadLine();

            if (name == "banana" || name == "apple" || name == "kiwi" || name == "cherry" || name == "lemon" || name == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (name == "tomato" || name == "cucumber" || name == "pepper" || name == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else { Console.WriteLine("unknown"); }
        }
    }
}