using System;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] _)
        {
            /*  Write a program that:
             *  ----------------------------
             *  - Reads a list of integers from the console and receives commands to manipulate the list
             *  - Then until you receive "end", you will receive different commands:
             *  ----------------------------
             *  o	"Delete {element}" – delete all elements in the array, which are equal to the given element
             *  o	"Insert {element} {position}" – insert the element at the given position
             *  ----------------------------
             *  When you receive the "end" command, print the final state of the list (separated by spaces)
             *  -----------------------------
             *  |   Example Input / Output  |
             *  -----------------------------------------
             *  |   Input           |   Output          |
             *  -----------------------------------------
             *  |   1 2 3 4 5 5 5 6 |                   |
             *  |   Delete 5        |                   |
             *  |   Insert 10 1     |                   |
             *  |   Delete 5        |                   |
             *  |   end             |   1 10 2 3 4 6    |
             *  -----------------------------------------
             */

            List<int> theFinalList = new List<int>(); //The list that we will work on for the final result
            string theInitialListContent = Console.ReadLine(); //The first input(string), that we will convert into the first value of the list(int)
            int index = 0; //The index of the next inputs for the words 'Delete ' or 'Insert ' that we will remove from the input to convert the rest
            int theNumToDelete = 0; //If we get a Delete... input, we use this to take the value of the num we should delete
            List<int> listOfNumToInsertAndPosition = new List<int>(); //For insert function, we save the values to ..[0] and ..[1]

            theFinalList = theInitialListContent.Split(' ').Select(int.Parse).ToList();
            //Giving 'theFinalList' it's initial values

            string input = Console.ReadLine(); //Every input untill 'end'

            while (input != "end")
            {
                if (input.Contains("Delete"))
                {
                    input = input.Remove(index, "Delete ".Length);
                    
                    theNumToDelete = Convert.ToInt32(input);
                    theFinalList.RemoveAll(item => theFinalList.Contains(theNumToDelete));
                }
                
                else if (input.Contains("Insert"))
                {
                    input = input.Remove(index, "Insert ".Length);

                    listOfNumToInsertAndPosition = input.Split(' ').Select(int.Parse).ToList();
                    int positionToInsert = listOfNumToInsertAndPosition[1];
                    int elementToInsert = listOfNumToInsertAndPosition[0];

                    theFinalList.Insert(positionToInsert, elementToInsert);
                }

                input = Console.ReadLine(); //Next input
            }

            foreach (int num in theFinalList)
            {
                Console.Write($"{num} ");
            }
        }
    }
}