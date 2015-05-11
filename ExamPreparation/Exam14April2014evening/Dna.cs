using System;

class Dna
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        char startChar = (char)Console.Read();
        int index = 3;
        int indexAdjustor = -1;


        for (int i = 0; i < length; i++)
        {
            Console.Write(new string('.', index));
            for (int j = 0; j < 7 - 2 * index; j++)
            {
                Console.Write(startChar++);
                if (startChar == 'H')
                {
                    startChar = 'A';
                }
            }
            Console.WriteLine(new string('.', index));
            index += indexAdjustor;
            if (index == 0)
            {
                indexAdjustor *= -1;
            }
            if (index == 4)
            {
                index = 3;
                indexAdjustor *= -1;
            }
           
        }
    }
}