using System;
using System.Linq;

class BiggestNum
{
    static void Main()
    {
        double[] myArr = new double[5];

        for (int i = 0; i < 5; i++)
        {
            myArr[i] = double.Parse(Console.ReadLine());
        }
        
        double biggestNum = myArr.Max();
        Console.WriteLine(biggestNum);
    }
}