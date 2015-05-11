using System;
class ASCII
{
    static void Main()
    {
        for (int i = 0; i < 256; i++)
        {
            char c = (char) i;
            Console.WriteLine(c);
        }
    }
}