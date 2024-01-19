using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            double averageGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averageGrade:F2}");
        }
    }
}