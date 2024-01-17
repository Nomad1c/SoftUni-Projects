using System;

namespace GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            string inputType = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string result = Compare(inputType, input1, input2);
            Console.WriteLine(result);
        }

        static string Compare(string type, string a, string b)
        {
            string result = String.Empty;

            if (type == "int")
            {
                int x = Convert.ToInt32(a);
                int y = Convert.ToInt32(b);
                result = (x > y) ? a : b;
            }

            else if (type == "char")
            {
                char xx = Convert.ToChar(a);
                char yy = Convert.ToChar(b);
                result = (xx > yy) ? a : b;
            }

            else if (type == "string")
            {
                int length = Math.Min(a.Length, b.Length);

                for (int i = 0; i < length; i++)
                {
                    char xxx = Convert.ToChar(a.Substring(i, 1));
                    char yyy = Convert.ToChar(b.Substring(i, 1));

                    if (xxx > yyy)
                    {
                        result = a;
                        break;
                    }
                    else if (yyy > xxx)
                    {
                        result = b;
                        break;
                    }
                }
            }

            return result;
        }
    }
}