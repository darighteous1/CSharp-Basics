using System;
using System.Numerics;

class TicTacToe
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];
        int y = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        //fill matrix
        int index = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = value + index;
                index++;
            }
        }
        
        int[,] indexes = new int[3, 3];
        index = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                indexes[i, j] = index;
                index++;
            }
        }

       
        BigInteger result = (BigInteger)Math.Pow(matrix[x, y], indexes[x, y]);
        Console.WriteLine(result);

        
    }
}