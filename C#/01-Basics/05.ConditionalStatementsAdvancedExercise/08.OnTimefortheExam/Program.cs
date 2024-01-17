using System;

namespace OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            //Time for exam
            int examHours = Convert.ToInt32(Console.ReadLine());
            int examMinutes = Convert.ToInt32(Console.ReadLine());
            //Arival time
            int arivalHours = Convert.ToInt32(Console.ReadLine());
            int arivalMinutes = Convert.ToInt32(Console.ReadLine());

            //Calculate the minutes and hours into minutes only
            int calcExam = examMinutes + examHours * 60;
            int calcArival = arivalMinutes + arivalHours * 60;
            double diference, div;
            diference = calcExam - calcArival;
            div = diference / 30;


            if (div <= 1 && div > 0)        
            {                                      
                Console.WriteLine("On time");
                double a = Math.Abs(diference);
                Console.WriteLine($"{a} minutes before the start");
            }

            else if (div == 0)
            {
                Console.WriteLine("On time");
            }

            else if (div > 1)
            {
                Console.WriteLine("Early");

                if (diference < 60)
                {
                    Console.WriteLine($"{diference} minutes before the start");
                }
                else
                {
                    int c = Convert.ToInt32(Math.Floor(Math.Abs(diference % 60)));
                    int b = Convert.ToInt32(Math.Floor(Math.Abs(diference / 60)));
                    TimeSpan timeSpan = new TimeSpan(0, b, c);
                    Console.WriteLine($"{timeSpan:m\\:ss} hours before the start");
                }
            }
            else if (div < 0)
            {
                Console.WriteLine("Late");

                if (Math.Abs(diference) < 60)
                {
                    Console.WriteLine($"{Math.Abs(diference)} minutes after the start");
                }
                else
                {
                    int c = Convert.ToInt32(Math.Floor(Math.Abs(diference % 60)));
                    int b = Convert.ToInt32(Math.Floor(Math.Abs(diference / 60)));
                    TimeSpan timeSpan = new TimeSpan(0, b, c);
                    Console.WriteLine($"{timeSpan:m\\:ss} hours after the start");
                }

            }
        }
    }
}