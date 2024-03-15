using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());

            int courses = Convert.ToInt32(Math.Floor((double)n/p));

            if (courses > 0 )
            {
                Console.WriteLine($"{courses} courses * {p} people");
            }

            else
            {
                Console.WriteLine("All the persons fit inside in the elevator.");
                Console.WriteLine("Only one course is needed.");
            }

            int rest = n % p;

            if ( rest != 0 )
            {
                Console.WriteLine($"+ 1 courcse * {rest} people");
            }
        }
    }
}