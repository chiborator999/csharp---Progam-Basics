using System;
using System.Linq;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEggs = int.Parse(Console.ReadLine());
            string color = string.Empty;
            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;

            for (int i = 1; i <= numEggs; i++)
            {
                color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        redCount++;
                        break;
                    case "orange":
                        orangeCount++;
                        break;
                    case "blue":
                        blueCount++;
                        break;
                    case "green":
                        greenCount++;
                        break;
                }
            }

            string[] nameColor = {"red", "orange", "blue", "green"};
            int[] counter = {redCount, orangeCount, blueCount, greenCount};
            int max = counter.Max();
            int maxIndex = counter.ToList().IndexOf(max);

//            $maxEggsCount = $redEggsCount;
//            $maxColor = 'red';

//            if ($orangeEggsCount > $maxEggsCount)
//            {
//                  $maxEggsCount = $orangeEggsCount;
//                  $maxColor = 'orange';
//            }
//            if ($blueEggsCount > $maxEggsCount) 
//            {
//                  $maxEggsCount = $blueEggsCount;
//                  $maxColor = 'blue';
//            }
//            if ($greenEggsCount > $maxEggsCount) 
//            {
//                  $maxEggsCount = $greenEggsCount;
//                  $maxColor = 'green';
//            }

            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            Console.WriteLine($"Max eggs: {max} -> {nameColor[maxIndex]}");
        }
    }
}
