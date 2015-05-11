using System;

class Cards
{
    static void Main()
    {
        string card = Console.ReadLine();

        switch (card)
        {
            case "J":
                Console.WriteLine("yes");
                break;
            case "Q":
                Console.WriteLine("yes");
                break;
            case "K":
                Console.WriteLine("yes");
                break;
            case "A":
                Console.WriteLine("yes");
                break;
            default:
                int numCard;
                bool check = Int32.TryParse(card, out numCard);
                if (check)
                {
                    if (numCard >= 2 && numCard <= 10)
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }
                }
                else
                {
                    Console.WriteLine("no");
                }
                break;
        }
    }
}