using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            //Дали може да изгледа епизод от сериала си.
            //Цел: дали имаме достатъчно време?
            
            //Време за обяд: 1/8 от времето за почивка.
            //Време за отдих: 1/4 от времето за почивка.

            //Input:
            string name = Console.ReadLine();                       //Име сериал
            int lenghtTime = Convert.ToInt32(Console.ReadLine());   //Продължителност
            int breakTime = Convert.ToInt32(Console.ReadLine());    //Почивка

            double lunchTime = breakTime * 0.125;                   //Време за обяд
            double restTime = breakTime * 0.25;                     //Време за отдих

            double enoughTime = breakTime - lunchTime - restTime - lenghtTime;

            if (enoughTime >= 0)
            {
                int enoughTime2 = Convert.ToInt32(Math.Ceiling(enoughTime));
                Console.WriteLine($"You have enough time to watch {name} and left with {enoughTime2:F0} minutes free time.");
            }
            else
            {
                int timeLeft = Convert.ToInt32(Math.Ceiling(Math.Abs(enoughTime)));
                Console.WriteLine($"You don't have enough time to watch {name}, you need {timeLeft:F0} more minutes.");
            }

        }

    }
}