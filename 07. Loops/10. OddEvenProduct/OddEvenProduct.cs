using System;

class OddEvenProduct
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < input.Length; i += 2)
        {
            oddProduct *= int.Parse(input[i]);
            if (i == input.Length - 1)
            {
                break;
            }
            evenProduct *= int.Parse(input[i + 1]);
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}