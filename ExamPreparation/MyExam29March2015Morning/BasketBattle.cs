using System;

class BasketBattle
{
    static void Main()
    {
        string firstPlayer = Console.ReadLine();
        string secondPlayer = firstPlayer == "Simeon" ? "Nakov" : "Simeon";
        int numberOfRounds = int.Parse(Console.ReadLine());

        int firstPlayerScore = 0;
        int secondPlayerScore = 0;
        bool isFirstPlayer = true;

        for (int currentRound = 1; currentRound <= numberOfRounds; currentRound++)
        {
            for (int i = 0; i < 2; i++)
            {
                int shot = int.Parse(Console.ReadLine());
                string result = Console.ReadLine();

                if (result == "success")
                {
                    if (isFirstPlayer && (firstPlayerScore + shot) <= 500)
                    {
                        firstPlayerScore += shot;
                    }
                    if (!isFirstPlayer && (secondPlayerScore + shot) <= 500)
                    {
                        secondPlayerScore += shot;
                    }
                }

                if (firstPlayerScore == 500)
                {
                    if (secondPlayerScore == 500)
                    {
                        Console.WriteLine("DRAW");
                        Console.WriteLine(firstPlayerScore);
                    }
                    Console.WriteLine(firstPlayer);
                    Console.WriteLine(currentRound);
                    Console.WriteLine(secondPlayerScore);
                    return;
                }
                if (secondPlayerScore == 500)
                {
                    if (firstPlayerScore == 500)
                    {
                        Console.WriteLine("DRAW");
                        Console.WriteLine(firstPlayerScore);
                    }
                    Console.WriteLine(secondPlayer);
                    Console.WriteLine(currentRound);
                    Console.WriteLine(firstPlayerScore);
                    return;
                }
                isFirstPlayer = !isFirstPlayer;
            }
            isFirstPlayer = !isFirstPlayer;
        }
        if (firstPlayerScore == secondPlayerScore)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(firstPlayerScore);
        }
        if (firstPlayerScore > secondPlayerScore)
        {
            Console.WriteLine(firstPlayer);
            Console.WriteLine(firstPlayerScore - secondPlayerScore);
        }
        if (secondPlayerScore > firstPlayerScore)
        {
            Console.WriteLine(secondPlayer);
            Console.WriteLine(secondPlayerScore - firstPlayerScore);
        }
    }
}