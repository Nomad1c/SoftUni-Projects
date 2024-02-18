using System;
using System.Collections.Generic;
using System.Linq;

public class NumberSequenceModifier
{
    public static void Main(string[] args)
    {
        // Get the initial sequence
        string input = Console.ReadLine();
        List<int> sequence = input.Split(' ').Select(int.Parse).ToList();

        // Process commands until "Finish" is received
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Finish")
            {
                break;
            }

            string[] cmdParts = command.Split(' ');
            string cmdType = cmdParts[0];

            switch (cmdType)
            {
                case "Add":
                    int addValue = int.Parse(cmdParts[1]);
                    sequence.Add(addValue);
                    break;

                case "Remove":
                    int removeValue = int.Parse(cmdParts[1]);
                    sequence.Remove(sequence.FirstOrDefault(x => x == removeValue));
                    break;

                case "Replace":
                    int replaceValue = int.Parse(cmdParts[1]);
                    int replacementValue = int.Parse(cmdParts[2]);
                    int index = sequence.IndexOf(replaceValue);
                    if (index >= 0)
                    {
                        sequence[index] = replacementValue;
                    }
                    break;

                case "Collapse":
                    int collapseValue = int.Parse(cmdParts[1]);
                    sequence = sequence.Where(x => x >= collapseValue).ToList();
                    break;

                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }

        // Print the final sequence
        Console.WriteLine(string.Join(" ", sequence));
    }
}
