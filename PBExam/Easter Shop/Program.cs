using System;

namespace Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = int.Parse(Console.ReadLine());
            int eggsAmount = 0;
            int eggsSold = 0;
            int eggsLeft = 0;
            bool isClose = false;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Close")
            {
                if (input == "Buy")
                {
                    eggsAmount = int.Parse(Console.ReadLine());
                    eggsSold += eggsAmount;
                    eggsLeft = eggs;
                    eggs -= eggsAmount;
                    if (eggs < 0)
                    {
                        isClose = true;
                        break;
                    }
                }
                else if (input == "Fill")
                {
                    eggsAmount = int.Parse(Console.ReadLine());
                    eggs += eggsAmount;
                }
            }
            if (isClose)
            {
                Console.WriteLine($"Not enough eggs in store!");
                Console.WriteLine($"You can buy only {eggsLeft}.");
            }
            else
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{eggsSold} eggs sold.");
            }
        }
    }
}
