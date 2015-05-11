using System;

class NullValues
{
    static void Main()
    {
        int? nullableInteger = null;
        double? nullableDouble = null;
        Console.WriteLine(nullableInteger);
        Console.WriteLine(nullableDouble);

        nullableInteger += 5;
        nullableDouble -= 10.3245;

        Console.WriteLine(nullableInteger);
        Console.WriteLine(nullableDouble);
    }
}