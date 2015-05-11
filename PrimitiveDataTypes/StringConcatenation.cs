using System;
class StringConcatenation
{
    static void Main()
    {
        string firstString = "Hello ";
        string secondString = "World";
        object concStrings = firstString + secondString;
        Console.WriteLine(concStrings);

        string thirdString = (string)concStrings;
    }
}