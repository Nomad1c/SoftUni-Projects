using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 0;


            if (n % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
                counter++;
            }
            else if (n % 7 == 0 && counter == 0)
            {
                Console.WriteLine("The number is divisible by 7");
                counter++;
            }
            else if (n % 6 == 0 && counter == 0)
            {
                Console.WriteLine("The number is divisible by 6");
                counter++;
            }
            else if (n % 3 == 0 && counter == 0)
            {
                Console.WriteLine("The number is divisible by 3");
                counter++;
            }
            else if (n % 2 == 0 && counter == 0)
            {
                Console.WriteLine("The number is divisible by 2");
                counter++;
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}