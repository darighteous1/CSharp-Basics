using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                count++;
                if ((step == 1) || (count % step == 1))
                {
                    num = num ^ (1 << bit);
                }
            }
            Console.WriteLine(num);
        }
    }
}
