using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            //input
            double lostGameCount = Convert.ToDouble(Console.ReadLine());
            double headsetPrice = Convert.ToDouble(Console.ReadLine());
            double mousePrice = Convert.ToDouble(Console.ReadLine());
            double keyboardPrice = Convert.ToDouble(Console.ReadLine());
            double displayPrice = Convert.ToDouble(Console.ReadLine());

            //calc
            //2 - headset
            //3 - mouse
            //6 - keyboard
            //12 - display
            double headsetBrakes = Math.Floor(lostGameCount / 2) * headsetPrice;
            double mouseBrakes = Math.Floor(lostGameCount / 3) * mousePrice;
            double keyboardBrakes = Math.Floor(lostGameCount / 6) * keyboardPrice;
            double displayBrakes = Math.Floor(lostGameCount / 12) * displayPrice;

            double total = headsetBrakes + mouseBrakes + keyboardBrakes + displayBrakes;

            //Output
            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}