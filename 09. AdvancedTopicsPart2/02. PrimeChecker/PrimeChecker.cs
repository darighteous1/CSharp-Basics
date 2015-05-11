using System;

class PrimeCheck
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));

    }

    private static bool IsPrime(ulong n)
    {
        bool isPrime = true;
        if (n > 0 && n <= ulong.MaxValue)
        {
            if (n == 1)
            {
                Console.WriteLine(!isPrime);
            }
            else if (n == 2)
            {
                Console.WriteLine(isPrime);
            }
            else
            {
                for (ulong i = 3; i <= Math.Sqrt(n); i += 2)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
        }
        return isPrime;
    }
}