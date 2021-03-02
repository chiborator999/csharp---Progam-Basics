using System;

namespace Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nigths = int.Parse(Console.ReadLine());
            double price = 0;

            if (date == "21-23")
            {
                if (destination == "France")
                {
                    price = 30;
                }
                else if (destination == "Italy")
                {
                    price = 28;
                }
                else if (destination == "Germany")
                {
                    price = 32;
                }
            }
            else if (date == "24-27")
            {
                if (destination == "France")
                {
                    price = 35;
                }
                else if (destination == "Italy")
                {
                    price = 32;
                }
                else if (destination == "Germany")
                {
                    price = 37;
                }
            }
            else if (date == "28-31")
            {
                if (destination == "France")
                {
                    price = 40;
                }
                else if (destination == "Italy")
                {
                    price = 39;
                }
                else if (destination == "Germany")
                {
                    price = 43;
                }
            }
            price = price * nigths;

            Console.WriteLine($"Easter trip to {destination} : {price:F2} leva.");
        }
    }
}
