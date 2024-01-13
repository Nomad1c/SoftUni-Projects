using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double n1 = Convert.ToInt32(Console.ReadLine());
            double n2 = Convert.ToInt32(Console.ReadLine());
            string simboll;
                simboll = Console.ReadLine();
            double n;

            switch (simboll) 
                {
                case "+":
                    n = n1 + n2;
                    if (n % 2 == 0)
                    {
                        Console.WriteLine(n1 + " + " + n2 + " = " + n + " - even");
                    }
                    else
                    {
                        Console.WriteLine(n1 + " + " + n2 + " = " + n + " - odd");
                    }
                    break;

                case "-":
                    n = n1 - n2;
                    if (n % 2 == 0)
                    {
                        Console.WriteLine(n1 + " - " + n2 + " = " + n + " - even");
                    }
                    else
                    {
                        Console.WriteLine(n1 + " - " + n2 + " = " + n + " - odd");
                    }
                    break;

                case "*":
                    n = n1 * n2;
                    if (n % 2 == 0)
                    {
                        Console.WriteLine(n1 + " * " + n2 + " = " + n + " - even");
                    }
                    else
                    {
                        Console.WriteLine(n1 + " * " + n2 + " = " + n + " - odd");
                    }
                    break;

                case "/":
                    
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        n = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {n:F2}");
                    }
                    break;

                case "%":
                    
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        n = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {n}");
                    }
                    break;

            }
        }
    }
}