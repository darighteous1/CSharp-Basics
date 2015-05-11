using System;

class Boxception
{
    static void Main()
    {
        int[] boxOne = new int[3];
        int[] boxTwo = new int[3];

        //create boxes
        for (int i = 0; i < 3; i++)
        {
            boxOne[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 3; i++)
        {
            boxTwo[i] = int.Parse(Console.ReadLine());
        }

        if ((CanFit(boxOne, boxTwo) == false) && (CanFit(boxTwo, boxOne) == false))
        {
            return;
        }

        if (CanFit(boxOne, boxTwo) == true)
        {
            int[] v1 = { boxTwo[0], boxTwo[1], boxTwo[2] };
            int[] v2 = { boxTwo[0], boxTwo[2], boxTwo[1] };
            int[] v3 = { boxTwo[1], boxTwo[0], boxTwo[2] };
            int[] v4 = { boxTwo[1], boxTwo[2], boxTwo[0] };
            int[] v5 = { boxTwo[2], boxTwo[1], boxTwo[0] };
            int[] v6 = { boxTwo[2], boxTwo[0], boxTwo[1] };

            int[][] versions = new int[][] { v1, v2, v3, v4, v5, v6 };
            for (int i = 0; i < versions.Length; i++)
            {
                if (Fits(boxOne, versions[i]))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", boxOne[0], boxOne[1], boxOne[2], versions[i][0], versions[i][1], versions[i][2]);
                }
            }
        }
        if (CanFit(boxTwo, boxOne) == true)
        {
            int[] v1 = { boxOne[0], boxOne[1], boxOne[2] };
            int[] v2 = { boxOne[0], boxOne[2], boxOne[1] };
            int[] v3 = { boxOne[1], boxOne[0], boxOne[2] };
            int[] v4 = { boxOne[1], boxOne[2], boxOne[0] };
            int[] v5 = { boxOne[2], boxOne[1], boxOne[0] };
            int[] v6 = { boxOne[2], boxOne[0], boxOne[1] };

            int[][] versions = new int[][] { v1, v2, v3, v4, v5, v6 };
            for (int i = 0; i < versions.Length; i++)
            {
                if (Fits(boxTwo, versions[i]))
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", boxTwo[0], boxTwo[1], boxTwo[2], versions[i][0], versions[i][1], versions[i][2]);
                }
            }
        }
    }

    private static bool CanFit(int[] boxOne, int[] boxTwo)
    {
        for (int i = 0; i < 3; i++)
        {
            if (boxOne[i] > boxTwo[0] && boxOne[i] > boxTwo[1] && boxOne[i] > boxTwo[2])
            {
                return false;
            }
        }
        return true;
    }
    static bool Fits(int[] boxOne, int[] boxTwo)
    {
        bool checkOne = (boxOne[0] <= boxTwo[0]);
        bool checkTwo = (boxOne[1] <= boxTwo[1]);
        bool checkThree = (boxOne[2] <= boxTwo[2]);
        if (checkOne && checkTwo && checkThree)
        {
            return true;
        }
        return false;
    }
}