using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Gambling
{
    static void Main()
    {
        double cash = double.Parse(Console.ReadLine());
        double pot = 2*cash;
        string[] computerDraw = Console.ReadLine().Split();
        int computerHand = CalculateHand(computerDraw);

        double chanceOfWinning = WinningHands(computerHand) / 28561.0;   //28561 is the total number of available hands (13^4)     
        double projectedWinings = chanceOfWinning * pot;
        if (chanceOfWinning < 0.5)
        {
            Console.WriteLine("FOLD");
            Console.WriteLine("{0:F2}", projectedWinings);
        }
        else
        {
            Console.WriteLine("DRAW");
            Console.WriteLine("{0:F2}", projectedWinings);
        }
    }

    static int WinningHands(int computerHand)
    {
        int winningHands = 0;
        int totalHands = 0;
        for (int i = 2; i < 15; i++)
        {
            totalHands++;
            for (int j = 2; j < 15; j++)
            {
                for (int k = 2; k < 15; k++)
                {
                    for (int l = 2; l < 15; l++)
                    {
                        int currentHand = i + j + k + l;
                        if (currentHand > computerHand)
                        {
                            winningHands++;
                        }
                    }
                }
            }
        }
        return winningHands;
    }
    static int CalculateHand(string[] hand)
    {
        int value = 0;
        for (int i = 0; i < hand.Length; i++)
        {

            switch (hand[i])
            {
                case "J":
                    value += 11;
                    break;
                case "Q":
                    value += 12;
                    break;
                case "K":
                    value += 13;
                    break;
                case "A":
                    value += 14;
                    break;
                default:
                    value += int.Parse(hand[i]);
                    break;
            }
        }
        return value;
    }
}