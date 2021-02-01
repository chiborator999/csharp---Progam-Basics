using System;

namespace Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerOne = int.Parse(Console.ReadLine());
            int playerTwo = int.Parse(Console.ReadLine());
            string input = string.Empty;
            bool isZero = false;
            while ((input = Console.ReadLine()) != "End of battle")
            {
                if (input == "one")
                {
                    playerTwo -= 1;
                }
                else if (input == "two")
                {
                    playerOne -= 1;
                }

                if (playerOne == 0 || playerTwo == 0)
                {
                    isZero = true;
                    break;
                }
            }
            if(isZero)
            {
                if (playerOne == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwo} eggs left.");
                }
                else if (playerTwo == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playerOne} eggs left.");
                }
            }
            else
            {
                Console.WriteLine($"Player one has {playerOne} eggs left.");
                Console.WriteLine($"Player two has {playerTwo} eggs left.");
            }
        }
    }
}
