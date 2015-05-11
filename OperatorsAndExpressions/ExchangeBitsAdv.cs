using System;

class EchangeBitsAdvanced
{
    static void Main()
    {
        uint num = 0;
        try
        {
            num = uint.Parse(Console.ReadLine());
        }
        catch (OverflowException)
        {
            Console.WriteLine("Out of range!");
            return;
        }     
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        
        if (p >= q || p < 0 || (q+k-1) > 31)
        {
            Console.WriteLine("Out of range!");
            return;
        }
        if (p + k - 1 >= q)
        {
            Console.WriteLine("Overlapping");
            return;
        }
        
        for (int i = 0; i < k; i++)
        {
            if (BitValue(num, p) == BitValue(num, q))
            {
                p++;
                q++;
                continue;
            }
            else
            {
            num = BitSwap(num, BitValue(num, p), BitValue(num, q), p, q);
            }
            p++;
            q++;
        }
        Console.WriteLine(num);
    }

    static uint BitValue(uint num, int pos)
    {
        int mask = 1;
        uint bitValue = (uint)((num >> pos) & mask);
        return bitValue;
    }

    static uint Mask(uint value, int pos)
    {
        uint mask = new uint();
        if (value == 1)
        {
            mask = (uint)(1 << pos);
        }
        else
        {
            mask = (uint)(~(1 << pos));
        }
        return mask;
    }
    static uint BitSwap(uint num, uint bit1, uint bit2, int p, int q)
    {
        if (bit1 > bit2)
        {
            uint tempBit = bit2;
            bit2 = bit1;
            bit1 = bit2;
            num = num | Mask(1, q);
            num = num & Mask(0, p);
        }
        else
        {
            uint tempBit = bit2;
            bit2 = bit1;
            bit1 = bit2;
            num = num | Mask(1, p);
            num = num & Mask(0, q);
        }
        return num;
    }
}