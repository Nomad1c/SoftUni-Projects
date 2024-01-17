namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            //Input
            double budget = Convert.ToDouble(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());    //Видеокарти
            int M = Convert.ToInt32(Console.ReadLine());    //Процесори
            int P = Convert.ToInt32(Console.ReadLine());    //РАМ

            //Цени
            double priceN = N * 250;                    //Цена видеокарти
            double priceM = priceN * 0.35 * M;          //Цена процесори
            double priceP = priceN * 0.1 * P;           //Цена РАМ
            double total = priceN + priceM + priceP;    //Цена общо

            if (N > M)
            {
                //15% отстъпка от крайната сметка
                total *= 0.85;
            }

            if (budget > total)
            {
                double left = budget - total;
                Console.WriteLine($"You have {left:F2} leva left!");
            }
            else
            {
                double left = total - budget;
                Console.WriteLine($"Not enough money! You need {left:F2} leva more!");
            }
        }
    }
}