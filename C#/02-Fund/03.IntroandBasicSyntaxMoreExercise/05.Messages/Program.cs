using System.Text;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int length = int.Parse(Console.ReadLine());
            string message = GetMessage(length);
            Console.WriteLine(message);
        }

        static string GetMessage(int length)
        {
            StringBuilder message = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                string sequence = Console.ReadLine();
                char letter = ConvertSequenceToMessage(sequence);
                message.Append(letter);
            }

            return message.ToString();
        }

        static char ConvertSequenceToMessage(string sequence)
        {
            int digitCount = sequence.Length;
            char mainDigit = sequence[0];

            switch (mainDigit)
            {
                case '2': return (char)('a' + (digitCount - 1) % 3);
                case '3': return (char)('d' + (digitCount - 1) % 3);
                case '4': return (char)('g' + (digitCount - 1) % 3);
                case '5': return (char)('j' + (digitCount - 1) % 3);
                case '6': return (char)('m' + (digitCount - 1) % 3);
                case '7': return (char)('p' + (digitCount - 1) % 4);
                case '8': return (char)('t' + (digitCount - 1) % 3);
                case '9': return (char)('w' + (digitCount - 1) % 4);
                case '0': return ' ';
                default: return ' ';
            }
        }
    }
}