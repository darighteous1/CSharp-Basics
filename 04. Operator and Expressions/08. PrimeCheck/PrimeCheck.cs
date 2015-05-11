using System;

class PrimeCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // ne raboti tochno!~!!!!!!!!!!!!!!!
        if (n > 0 && n <= 100)
        {
            if (n == 1)
            {
                Console.WriteLine(false);
            }
            else if(n == 2)
            {
                Console.WriteLine(true);
            }
            else
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(false);
                        break;
                    }
                    
                }

               
            }
        }
    }
}