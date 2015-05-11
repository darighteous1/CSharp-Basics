using System;

class EchangeBits
{
    static void Main()
    {
        uint num = 1140867093; //result should be 1107312677
        uint numDublicate = num;
        Console.WriteLine(Convert.ToString(num, 2));
        uint bit3 = BitValue(num, 3); //0
        uint bit4 = BitValue(num, 4); //1
        uint bit5 = BitValue(num, 5); //0
        uint bit24 = BitValue(num, 24); //0
        uint bit25 = BitValue(num, 25); //0
        uint bit26 = BitValue(num, 26); //1
        
        //swap 3 and 24 (they are equal)
        uint tempBit = bit24; 
        bit24 = bit3;
        bit3 = tempBit;
        num = num & Mask(0, 24);
        num = num & Mask(0, 3);
        //swap 4 and 25
        tempBit = bit25; //method for bitvalue swap?
        bit25 = bit4;
        bit4 = tempBit;
        num = num | Mask(1, 25);
        num = num & Mask(0, 4);
        //swap 5 and 26
        tempBit = bit26;
        bit26 = bit5;
        bit5 = tempBit;
        num = num | Mask(1, 5);
        num = num & Mask(0, 26);

        Console.WriteLine(Convert.ToString(numDublicate, 2));
        Console.WriteLine(Convert.ToString(num, 2));
        Console.WriteLine(num);
        
    }

    static uint BitValue(uint num, int pos)
    {
        int mask = 1;
        uint bitValue = (uint)((num >> pos) & mask);
        return bitValue;
    }
    
    static uint Mask (uint value, int pos)
    {
        uint mask = new uint();
        if (value == 1)
        {
            mask = (uint)(1<<pos);
        }
        else
        {
            mask = (uint)(~(1 << pos));
        }
        return mask;
    }
	
}