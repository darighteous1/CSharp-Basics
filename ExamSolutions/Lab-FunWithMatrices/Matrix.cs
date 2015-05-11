using System;
using System.Linq;

namespace Lab_FunWithMatrices
{
    class Matrix
    {
        static void Main(string[] args)
        {
            double startValue = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());
            double[,] matrix = new double[4, 4];
            double currentValue = startValue;

            //fill matrix
            matrix[0, 0] = startValue;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        matrix[i, j] = currentValue;
                    }
                    else
                    {
                        matrix[i, j] = currentValue + step;
                        currentValue = matrix[i, j];
                    }
                }
            }
            string input = Console.ReadLine();

            //calculations
            while (input != "Game Over!")
            {
                int row = int.Parse(input.Split()[0]);
                int col = int.Parse(input.Split()[1]);
                double num = double.Parse(input.Split()[3]);

                if (input.Split()[2] == "multiply")
                {
                    matrix[row, col] *= num;
                }
                else if (input.Split()[2] == "sum")
                {
                    matrix[row, col] += num;
                }
                else //power
                {
                    matrix[row, col] = Math.Pow(matrix[row, col], num);
                }
                input = Console.ReadLine();
            }

            //print matrix
            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0} ", matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            ////calculate max sums
            //double[] maxSums = { double.MinValue, double.MinValue, double.MinValue };

            //double leftDiagonalSum = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
            //double rightDiagonalSum = matrix[0, 3] + matrix[1, 2] + matrix[2, 1] + matrix[3, 0];
            //maxSums[2] = rightDiagonalSum > leftDiagonalSum ? rightDiagonalSum : leftDiagonalSum;
            //string maxDiag = rightDiagonalSum > leftDiagonalSum ? "RIGHT-DIAGONAL" : "LEFT-DIAGONAL";

            //int maxRow = 0;
            //int maxCol = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    double currentRowSum = 0;
            //    double currentColSum = 0;

            //    for (int j = 0; j < 4; j++)
            //    {
            //        currentRowSum += matrix[i, j];
            //        currentColSum += matrix[j, i];

            //        if (currentColSum > maxSums[1])
            //        {
            //            maxSums[1] = currentColSum;
            //            maxCol = j;
            //        }
            //    }

            //    if (currentRowSum > maxSums[0])
            //    {
            //        maxSums[0] = currentRowSum;
            //        maxRow = i;

            //    }
            //}
            double[] rowSumArr = new double[4];
            rowSumArr[0] = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[0, 3];
            rowSumArr[1] = matrix[1, 0] + matrix[1, 1] + matrix[1, 2] + matrix[1, 3];
            rowSumArr[2] = matrix[2, 0] + matrix[2, 1] + matrix[2, 2] + matrix[2, 3];
            rowSumArr[3] = matrix[3, 0] + matrix[3, 1] + matrix[3, 2] + matrix[3, 3];
            double maxRowSum = rowSumArr.Max();
            int maxRowIndex = Array.IndexOf(rowSumArr, maxRowSum);
            string maxRow = "ROW[" + maxRowIndex+ "]";

            double[] colSumArr = new double[4];
            colSumArr[0] = matrix[0, 0] + matrix[1, 0] + matrix[2, 0] + matrix[3, 0];
            colSumArr[1] = matrix[0, 1] + matrix[1, 1] + matrix[2, 1] + matrix[3, 1];
            colSumArr[2] = matrix[0, 2] + matrix[1, 2] + matrix[2, 2] + matrix[3, 2];
            colSumArr[3] = matrix[0, 3] + matrix[1, 3] + matrix[2, 3] + matrix[3, 3];
            double maxColSum = colSumArr.Max();
            int maxColIndex = Array.IndexOf(colSumArr, maxColSum);
            string maxCol = "COLUMN[" + maxColIndex + "]";

            double leftDiagonal = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
            double rightDiagonal = matrix[0, 3] + matrix[1, 2] + matrix[2, 1] + matrix[3, 0];
            double maxDiagSum = rightDiagonal > leftDiagonal ? rightDiagonal : leftDiagonal;
            string maxDiag = rightDiagonal > leftDiagonal ? "RIGHT-DIAGONAL" : "LEFT-DIAGONAL";

            double[] maxSums = { maxRowSum, maxColSum, maxDiagSum };
            double max = maxSums.Max();
            int maxType = Array.IndexOf(maxSums, max);

            switch (maxType)
            {
                case 0:
                    Console.WriteLine("{0} = {1:F2}", maxRow, max);
                    break;
                case 1:
                    Console.WriteLine("{0} = {1:F2}", maxCol, max);
                    break;
                case 2:
                    Console.WriteLine("{0} = {1:F2}", maxDiag, max);
                    break;
            }
            //print matrix
            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0} ", matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            ////output strings
            //double maxValue = maxSums.Max();
            //string max = string.Empty;

            //if (maxValue == maxSums[0])
            //{
            //    max = "ROW[" + maxRow + "]";
            //}
            //else if (maxValue == maxSums[1])
            //{
            //    max = "COLUMN[" + maxCol + "]";
            //}
            //else
            //{
            //    max = maxDiag;
            //}
            //Console.WriteLine("{0} = {1:F2}", max, maxSums.Max());
        }
    }
}
