using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double grade = Convert.ToDouble(Console.ReadLine());

            grading(grade);
        }

        static double grading(double grade)
        {
            if (grade >= 2 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3 &&  grade <= 3.49)
            {
                Console.WriteLine("Average");
            }
            else if (grade >= 3.5 &&  grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.5 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.5)
            {
                Console.WriteLine("Excellent");
            }
            
            return 0;
        }
    }
}

//"Fail" - If th
//"Average" - 
//"Good" - If th
//"Very good" 
//"Excellent
