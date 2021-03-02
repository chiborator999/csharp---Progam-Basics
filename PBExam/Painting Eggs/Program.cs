using System;

namespace Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int numPartids = int.Parse(Console.ReadLine());
            double price = 0;
            if (size == "Large")
            {
                if (color == "Red")
                {
                    price = 16;
                }
                else if (color == "Green")
                {
                    price = 12;
                }
                else if (color == "Yellow")
                {
                    price = 9;
                }
            }
            if (size == "Medium")
            {
                if (color == "Red")
                {
                    price = 13;
                }
                else if (color == "Green")
                {
                    price = 9;
                }
                else if (color == "Yellow")
                {
                    price = 7;
                }
            }
            if (size == "Small")
            {
                if (color == "Red")
                {
                    price = 9;
                }
                else if (color == "Green")
                {
                    price = 8;
                }
                else if (color == "Yellow")
                {
                    price = 5;
                }
            }
            price = price * numPartids;
            price -= price * 0.35;
            Console.WriteLine($"{price:F2} leva.");
        }
    }
}
