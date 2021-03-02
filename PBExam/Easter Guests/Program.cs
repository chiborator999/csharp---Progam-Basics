using System;

namespace Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestNum = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double easternCake = Math.Ceiling(guestNum / 3.0);
            double easternCakePrice = easternCake * 4;
            int eggs = 2 * guestNum;
            double eggsPrice = eggs * 0.45;

            double price = easternCakePrice + eggsPrice;
            double diff = Math.Abs(budget - price);

            if (budget >= price)
            {
                Console.WriteLine($"Lyubo bought {easternCake} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {diff:F2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {diff:F2} lv. more.");
            }
        }
    }
}
