using System;

class CardDeck
{
    static void Main()
    {
        for (int j = 2; j <= 14; j++)
        {
            for (int i = 0; i < 4; i++)
            {
                char cardColor = ' ';

                switch (i)
                {
                    case 0:
                        cardColor = '♠';
                        break;
                    case 1:
                        cardColor = '♥';
                        break;
                    case 2:
                        cardColor = '♣';
                        break;
                    case 3:
                        cardColor = '♦';
                        break;
                }
                
                if (j > 10)
                {
                    switch (j)
                    {
                        case 11:
                            string card = "J";
                            string output = card + cardColor;
                            Console.Write(output.PadLeft(4));
                            break;
                        case 12:
                            card = "Q";
                            output = card + cardColor;
                            Console.Write(output.PadLeft(4));
                            break;
                        case 13:
                            card = "K";
                            output = card + cardColor;
                            Console.Write(output.PadLeft(4));
                            break;
                        case 14:
                            card = "A";
                            output = card + cardColor;
                            Console.Write(output.PadLeft(4));
                            break;
                    }
                }
                
                else
                {
                    string output = Convert.ToString(j) + Convert.ToString(cardColor);
                    Console.Write("{0}", output.PadLeft(4));
                }
            }
            
            Console.WriteLine();
        }
    }
}