using System;

namespace OnTimeforExam
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTimeInMinutes = examHour * 60 + examMinute;
            int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;

            int differenceInMinutes = arrivalTimeInMinutes - examTimeInMinutes;

            if (differenceInMinutes < -30)
            {
                Console.WriteLine("Early");

                if (differenceInMinutes < -59)
                {
                    int hours = Math.Abs(differenceInMinutes) / 60;
                    int remainingMinutes = Math.Abs(differenceInMinutes) % 60;
                    Console.WriteLine($"{hours:D1}:{remainingMinutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(differenceInMinutes)} minutes before the start");
                }
            }
            else if (differenceInMinutes <= 0)
            {
                Console.WriteLine("On time");

                if (differenceInMinutes < 0)
                {
                    Console.WriteLine($"{Math.Abs(differenceInMinutes)} minutes after the start");
                }
            }
            else
            {
                Console.WriteLine("Late");

                if (differenceInMinutes <= 59)
                {
                    Console.WriteLine($"{differenceInMinutes} minutes after the start");
                }
                else
                {
                    int hours = differenceInMinutes / 60;
                    int remainingMinutes = differenceInMinutes % 60;
                    Console.WriteLine($"{hours:D1}:{remainingMinutes:D2} hours after the start");
                }
            }
        }
    }
}