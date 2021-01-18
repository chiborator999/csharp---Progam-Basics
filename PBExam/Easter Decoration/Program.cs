using System;

namespace Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numClients = int.Parse(Console.ReadLine());
            string product = string.Empty;
            double price = 0;
            double avergePrice = 0;
            int counter = 0;
            for (int i = 1; i <= numClients; i++)
            {
                while ((product = Console.ReadLine()) != "Finish")
                {
                    counter++;
                    if(product == "basket")
                    {
                        price += 1.5;
                    }
                    else if (product == "wreath")
                    {
                        price += 3.8;
                    }
                    else if (product == "chocolate bunny")
                    {
                        price += 7;
                    }
                }
                if (counter % 2 == 0)
                {
                    price -= price * 0.2;
                }
                Console.WriteLine($"You purchased {counter} items for {price:F2} leva.");
                avergePrice += price;
                price = 0;
                counter = 0;
            }
            Console.WriteLine($"Average bill per client is: {avergePrice / numClients:F2} leva.");
        }
    }
}
