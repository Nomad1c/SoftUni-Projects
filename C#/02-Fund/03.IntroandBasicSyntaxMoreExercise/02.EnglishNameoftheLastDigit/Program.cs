namespace EnglishNameoftheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int number = int.Parse(Console.ReadLine());
            string result = GetLastDigitName(number);
            Console.WriteLine(result);
        }

        static string GetLastDigitName(int num)
        {
            int lastDigit = Math.Abs(num % 10);

            switch (lastDigit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Invalid input";
            }
        }
    }
}