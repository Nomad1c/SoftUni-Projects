using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            double openTabs = Convert.ToDouble(Console.ReadLine());
            double salary = Convert.ToDouble(Console.ReadLine());
            string name = "";

            for (int i = 0;  i < openTabs; i++)
            {
                name = Console.ReadLine();
                
                switch (name)
                {
                    case "Facebook":
                        salary -= 150;
                        break;

                    case "Instagram":
                        salary -= 100;
                        break;

                    case "Reddit":
                        salary -= 50;
                        break;
                }
            }

            if (salary <= 0 )
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}