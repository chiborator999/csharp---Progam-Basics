using System;

namespace Easter_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            int eggsPlates = int.Parse(Console.ReadLine());
            int bakerPowder = int.Parse(Console.ReadLine());

            double priceSugar = (flourPrice * 0.75);
            double priceSugarTotal = priceSugar * sugarKg;
            double eggsPlatesPrice = (flourPrice * 1.1) * eggsPlates;
            double bakerPowderPrice = (priceSugar * 0.2) * bakerPowder;

            double price = priceSugarTotal + eggsPlatesPrice + bakerPowderPrice + (flourPrice * flourKg);
            Console.WriteLine($"{price:F2}");
        }
    }
}
