using System;

class EncryptedMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();
        string direction = Console.ReadLine();

        string conversion = String.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            conversion += (input[i] % 10);
        }

        string encryption = String.Empty;
        for (int i = 0; i < conversion.Length; i++)
        {
            if (conversion.Length == 1)
            {
                int currentDigit = int.Parse(conversion[i].ToString());
                if (currentDigit%2==0)
                {
                    encryption += currentDigit * currentDigit;
                    break;
                }
                else
                {
                    encryption += currentDigit;
                    break;
                }
            }
            if (i == 0 || i == conversion.Length - 1)
            {
                int currentDigit = int.Parse(conversion[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    encryption += currentDigit * currentDigit;
                }
                else
                {
                    int kucataCifra = int.Parse(conversion[i - 1 > 0 ? i - 1 : i + 1].ToString());
                    encryption += (currentDigit + kucataCifra);
                }
            }
            else
            {
                int currentDigit = int.Parse(conversion[i].ToString());
                if (currentDigit % 2 == 0)
                {
                    encryption += (currentDigit * currentDigit);
                }
                else
                {
                    int leftDigit = int.Parse(conversion[i - 1].ToString());
                    int rightDigit = int.Parse(conversion[i + 1].ToString());
                    encryption += (currentDigit + leftDigit + rightDigit);
                }
            }
        }

        int n = encryption.Length;
        int[,] matrix = new int[n, n];


        if (direction == "\\")
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, i] = int.Parse(encryption[i].ToString());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        if (direction == "/")
        {
            int col = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                matrix[col, i] = int.Parse(encryption[i].ToString());
                col++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}