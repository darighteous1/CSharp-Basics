using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = Console.ReadLine().ToUpper();

        char[,] matrix = new char[n, n];

        int row = 0, col = 0, size = n, currentChar = 0;

        while (size > 0)
        {
            for (int i = col; i <= col + size - 1; i++)
            {
                matrix[row, i] = word[currentChar % word.Length];
                currentChar++;
            }

            for (int j = row + 1; j <= row + size - 1; j++)
            {
                matrix[j, col + size - 1] = word[currentChar % word.Length];
                currentChar++;
            }

            for (int i = col + size - 2; i >= col; i--)
            {
                matrix[row + size - 1, i] = word[currentChar % word.Length];
                currentChar++;
            }

            for (int i = row + size - 2; i >= row + 1; i--)
            {
                matrix[i, col] = word[currentChar % word.Length];
                currentChar++;
            }

            row = row + 1;
            col = col + 1;
            size = size - 2;
        }

        int maxWeight = 0, rowNumber = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int currentWeight = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                currentWeight += (matrix[i, j] - 64);
            }

            if (currentWeight > maxWeight)
            {
                maxWeight = currentWeight;
                rowNumber = i;
            }
        }
        Console.WriteLine(rowNumber + " - " + maxWeight*10);
    }
}