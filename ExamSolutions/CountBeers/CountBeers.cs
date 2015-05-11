using System;
using System.Collections.Generic;
using System.Linq;

namespace CountBeers
{
    class CountBeers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                Console.WriteLine("0 stacks + 0 beers");
                return;
            }
            Dictionary<string, int> beerCount = new Dictionary<string, int>();

            while (input != "End")
            {
                string[] inputArr = input.Split();
                if (inputArr.Contains("beers"))
                {
                    if (!beerCount.ContainsKey("beers"))
                    {
                        int beers = int.Parse(inputArr[0]);
                        beerCount.Add("beers", beers);
                    }
                    else
                    {
                        int beers = int.Parse(inputArr[0]);
                        beerCount["beers"] += beers;
                    }
                }
                else
                {
                    if (!beerCount.ContainsKey("stacks"))
                    {
                        int stacks = int.Parse(inputArr[0]);
                        beerCount.Add("stacks", stacks);
                    }
                    else
                    {
                        int stacks = int.Parse(inputArr[0]);
                        beerCount["stacks"] += stacks;
                    }
                }
                input = Console.ReadLine();
            }
            
            if (beerCount.ContainsKey("beers") && beerCount["beers"] >= 20)
            {
                int additionaStacks = beerCount["beers"] / 20;
                beerCount["beers"] %= 20;
                beerCount["stacks"] += additionaStacks;
            }
            int x = beerCount.ContainsKey("stacks")? beerCount["stacks"] : 0;
            int y = beerCount.ContainsKey("beers") ? beerCount["beers"] : 0;
            Console.WriteLine("{0} stacks + {1} beers", x, y);
        }
    }
}
