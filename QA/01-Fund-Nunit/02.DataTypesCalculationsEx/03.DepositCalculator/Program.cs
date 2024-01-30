using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double depositedAmount = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double accumulatedInterest = depositedAmount * annualInterestRate / 100;
            double monthlyInterest = accumulatedInterest / 12;
            double totalAmount = depositedAmount + termOfDeposit * monthlyInterest;

            Console.WriteLine($"{totalAmount:F2}");
        }
    }
}