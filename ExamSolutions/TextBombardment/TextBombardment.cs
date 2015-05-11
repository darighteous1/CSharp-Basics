using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextBombardment
{
    static void Main()
    {
        string textInput = Console.ReadLine();
        string lineWidthStr = Console.ReadLine();
        int lineWidth = int.Parse(lineWidthStr);
        string columns = Console.ReadLine();
        string[] columnsNumbers = columns.Split();
        int[] columnsToBombard = new int[columnsNumbers.Length];

        for (int i = 0; i < columnsToBombard.Length; i++)
        {
            columnsToBombard[i] = int.Parse(columnsNumbers[i]);
        }

        string outputText = textInput;
        for (int i = 0; i < columnsToBombard.Length; i++)
        {
            int currentBomb = columnsToBombard[i];
            if (outputText[currentBomb] != ' ')
            {
            }
        }
        Console.WriteLine(outputText);
    }
}