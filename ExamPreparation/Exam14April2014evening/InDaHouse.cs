using System;
using System.Linq;
class InDaHouse
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        string[] results = new string[5];

        for (int i = 0; i < 5; i++)
        {
            int pointX = int.Parse(Console.ReadLine());
            int pointY = int.Parse(Console.ReadLine());
            if (pointX < 0 || pointY < 0)
            {
                results[i] = "outside";
            }

            else if (pointX <= 3 * h && pointY <= h)
            {
                results[i] = "inside";
            }
            else if (pointX >= h && pointX <= 2 * h && pointY <= 4 * h)
            {
                results[i] = "inside";
            }
            else
            {
                results[i] = "outside";
            }
        }
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }
    }
}