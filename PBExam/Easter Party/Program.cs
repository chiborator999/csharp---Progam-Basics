using System;

namespace Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestNum = int.Parse(Console.ReadLine());
            double oneGuestPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget * 0.1;

            if (guestNum >= 10 && guestNum <= 15)
            {
                oneGuestPrice -= oneGuestPrice * 0.15;
            }
            else if (guestNum > 15 && guestNum <= 20)
            {
                oneGuestPrice -= oneGuestPrice * 0.2;
            }
            else if (guestNum > 20)
            {
                oneGuestPrice -= oneGuestPrice * 0.25;
            }

            double price = (guestNum * oneGuestPrice) + cakePrice;
            double diff = Math.Abs(budget - price);

            if (budget >= price)
            {
                Console.WriteLine($"It is party time! {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {diff:F2} leva needed.");
            }
        }
    }
}
