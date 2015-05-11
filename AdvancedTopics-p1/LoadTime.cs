using System;
using System.Collections.Generic;
using System.Linq;

class LoadTime
{
    static void Main()
    {
        Dictionary<string, List<double>> loadTimes = new Dictionary<string, List<double>>();
        string input = Console.ReadLine();
        
        while (input != string.Empty)
        {
            input = input.Remove(0, 17).Trim();
            string[] inputArr = input.Split();
            if (!loadTimes.ContainsKey(inputArr[0]))
            {
                double time = double.Parse(inputArr[1]);
                List<double> times = new List<double>{time};
                loadTimes.Add(inputArr[0], times);
            }
            else
            {
                double time = double.Parse(inputArr[1]);
                loadTimes[inputArr[0]].Add(time);
            }
            input = Console.ReadLine();
        }
        foreach (var key in loadTimes.Keys)
        {
            Console.WriteLine("{0} -> {1}", key, loadTimes[key].Sum()/loadTimes[key].Count);
        }
        
    }
}