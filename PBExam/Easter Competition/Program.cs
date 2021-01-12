using System;

namespace Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEasternCake = int.Parse(Console.ReadLine());
            String name = string.Empty;
            string input = string.Empty;
            int score = 0;
            int maxScore = 0;
            string winName = string.Empty;

            for (int i = 1; i <= numEasternCake; i++)
            {
                name = Console.ReadLine();
                while((input = Console.ReadLine()) != "Stop")
                {
                    score += int.Parse(input);
                }
                Console.WriteLine($"{name} has {score} points.");
                if (score > maxScore)
                {
                    winName = name;
                    maxScore = score;
                    Console.WriteLine($"{name} is the new number 1!");
                }
                score = 0;
            }
            Console.WriteLine($"{winName} won competition with {maxScore} points!");
        }
    }
}
