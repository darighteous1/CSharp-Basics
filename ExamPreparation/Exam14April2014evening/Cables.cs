using System;

class Cables
{
    static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());
        int totalCableLength = 0;
        int usefulCables = 0;
        for (int i = 0; i < numberOfCables; i++)
        {
            int length = int.Parse(Console.ReadLine());
            string measure = Console.ReadLine();
            if (measure == "meters" || length >= 20)
            {
                usefulCables++;
                switch (measure)
                {
                    case"centimeters":
                        totalCableLength += length;
                    break;
                    case"meters":
                    totalCableLength += length * 100;
                    break;
                }
            }
        }
        totalCableLength = totalCableLength - ((usefulCables-1) * 3);

        int cableLength = 504; // 5m cable + 2*2cm for each of the RJ45 crimps
        int totalCables = totalCableLength / cableLength;
        int remainingCable = totalCableLength % cableLength;
        Console.WriteLine(totalCables);
        Console.WriteLine(remainingCable);
    }
}