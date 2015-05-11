using System;

class BitsKiller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int index = 0;
        string result = String.Empty;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(num,2));
            //Console.WriteLine();
            for (int j = 7; j >= 0; j--)
            {
                if (index != 0 && (step == 1 && index >= 3) || index % step == 1 || index == 3)
                {
                    num = KillTheFockinBit(num, j);
                    //Console.WriteLine(Convert.ToString(num, 2));
                    //Console.WriteLine();                
                }
                index++;

            }
            result += Convert.ToString(num, 2);
        }
        Console.WriteLine(result);

        while (result.Length % 8 != 0)
        {
            //
        }
    }
    static int KillTheFockinBit(int number, int position)
    {
        int left = number >> position;
        int right = ((1 << (position - 1)) - 1) & number;
        number = (left << (position - 1)) | right;
        return number;
    }
}