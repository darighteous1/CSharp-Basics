using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Beers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int count = 0;
        while (input != "End")
        {
            string[] inputArr = input.Split();
            if (inputArr[1] == "beers")
            {
                count += int.Parse(inputArr[1]);
            }
            else
            {
                count += int.Parse(inputArr[1]) * 20;
            }
        }
        Console.WriteLine("{0} stacks + {1} beers", count / 20, count % 20);
    }
}