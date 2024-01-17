	using System;
	
	namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine("You are " + name + " " + lastName + ", a " + age + "-years old person from " + town + ".");
        }
    }
}