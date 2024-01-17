using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            //Write a program that:
            //•	Read two integers numbers from the console in range[1…10]
            //•	Calculate the factorial of each number
            //•	Divide the first calculated factorial by the second calculated factorial(integer division)
            //•	Print the result of the division
            //Example Input / Output
            //Input Output
            //5
            //2      60
            //
            //6
            //2      360


            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int fac1 = Factorial(num1);
            int fac2 = Factorial(num2);

            int result = fac1 / fac2;
            Console.WriteLine(result);
        }

        static int Factorial(int a)
        {
            int result = a;
            int num = a;

            while (num > 1)
            {
                result *= (num - 1);
                num--;
            }

            return result;
        }
    }
}