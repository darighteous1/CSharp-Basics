using System;

class SequenceShort
{
    static void Main()
    {
        for (int num = 2; num < 12; num++) // the 'for' loop will go through all numbers that we need to print, i.e. from 2 to 11
        {
            if (num % 2 == 0) // this checks if the current number is even or odd
            {
                Console.Write(num + " "); // if the number is even, we'll print it on the console as it is
            }
            else
            {
                Console.Write(-num + " "); // if the number is odd, we'll print it with a '-' sign before it
            }
        }
        Console.WriteLine(); // this empty new line is here so the "Press any key to continue" is on a new line
    }
}