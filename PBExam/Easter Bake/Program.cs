using System;

namespace Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEasterCake = int.Parse(Console.ReadLine());
            int sugarMax = int.MinValue;
            int flourMax = int.MinValue;
            int sugar = 0;
            int flour = 0;
            double totalSugar = 0;
            double totalFlour = 0;

            for (int i = 1; i <= numEasterCake; i++)
            {
                sugar = int.Parse(Console.ReadLine());
                flour = int.Parse(Console.ReadLine());

                sugarMax = Math.Max(sugar, sugarMax);
                flourMax = Math.Max(flour, flourMax);

                totalSugar += sugar;
                totalFlour += flour;
            }
            totalSugar = Math.Ceiling(totalSugar / 950);
            totalFlour = Math.Ceiling(totalFlour / 750);

            Console.WriteLine($"Sugar: {totalSugar}");
            Console.WriteLine($"Flour: {totalFlour}");
            Console.WriteLine($"Max used flour is {flourMax} grams, max used sugar is {sugarMax} grams.");
        }
    }
}
