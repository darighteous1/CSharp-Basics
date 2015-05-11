using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _04.PokerStraight
{
    class PokerStraight
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int[] suits = { 1, 2, 3, 4 };
            int straightsFound = 0;

            for (int i = 0; i < cards.Length-4; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    for (int k = 0; k < suits.Length; k++)
                    {
                        for (int l = 0; l < suits.Length; l++)
                        {
                            for (int m = 0; m < suits.Length; m++)
                            {
                                for (int n = 0; n < suits.Length; n++)
                                {
                                    int sum = (10 * cards[i] + suits[j]) + (20 * cards[i + 1] + suits[k]) + (30 * cards[i + 2] + suits[l]) +
                                    (40 * cards[i + 3] + suits[m]) + (50 * cards[i + 4] + suits[n]);
                                    if (sum == weight)
                                    {
                                        straightsFound++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(straightsFound);
        }
    }
}
