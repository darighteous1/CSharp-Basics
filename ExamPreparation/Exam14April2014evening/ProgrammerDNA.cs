using System;

class ProgrammerDNA
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        char startingChar = (char)(Console.Read());
        
        char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        PrintDiamond(letters, startingChar, length);

    }

    private static void PrintDiamond(char[] letters, char startingChar, int length)
    {
        int charIndex = Array.IndexOf(letters, startingChar);
        int replaceIndexStart = 3;
        int replaceIndexEnd = 3;
        int rowCount = 0;

        for (int j = 0; j < length; j++)
        {
            if (rowCount != 0 && rowCount % 7 == 0)
            {
                replaceIndexStart = 3;
                replaceIndexEnd = 3;
                rowCount = 0;
            }
            if (rowCount > 3)
            {
                replaceIndexStart += 2;
                replaceIndexEnd -= 2;
            }
            for (int i = 0; i < 7; i++)
            {
                if (i >= replaceIndexStart && i <= replaceIndexEnd)
                {
                    Console.Write(letters[charIndex % 7]);
                    charIndex++;
                }
                else
                {
                    Console.Write('.');
                }
            }
            rowCount++;
            replaceIndexStart--;
            replaceIndexEnd++;
            Console.WriteLine();
        }
    }
}