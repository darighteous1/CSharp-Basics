﻿using System;

class FriendBits
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());

        uint friendBits = 0;
        uint aloneBits = 0;

        for (int i = 31; i >= 0; i--)
        {
            uint currentBit = (num >> i) & 1;

            bool hasLeftBit = (i < 31);
            uint leftBit = (num >> (i + 1)) & 1;
            bool sameLeftBit = hasLeftBit && (leftBit == currentBit);

            bool hasRightBit = (i > 0);
            uint rightBit = (num >> (i - 1)) & 1;
            bool sameRightBit = hasRightBit &&( rightBit == currentBit);

            bool friendBit = sameLeftBit || sameRightBit;
            if (friendBit)
            {
                friendBits = (friendBits << 1) | currentBit;
            }
            else
            {
                aloneBits = (aloneBits << 1) | currentBit;
            }
        }
        Console.WriteLine(friendBits);
        Console.WriteLine(aloneBits);
    }
}