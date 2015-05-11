using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] result = new int[n];

        int index = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int j = 7; j >= 0; j--)
            {
                if (index == 1 || index % step == 1 || ((step == 1) && (index != 0)))
                {
                    num = num | (1 << j);
                }
                
                index++;
            }
            result[i] = num;
        }
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
    }
}