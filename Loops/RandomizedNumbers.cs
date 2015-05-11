using System;

class RandomizeNumbers
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            nums[i] = i + 1;
        }

        ShuffleArray(nums);
        foreach (int num in nums)
        Console.Write("{0} ", num);
    }

    public static void ShuffleArray(int[] array)
    {
        int index, temp;
        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            index = rnd.Next(array.Length);

            temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
    }
}