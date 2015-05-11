using System;

class Sunglasses
{
    static void Main()
    {
        int glassesHeight = int.Parse(Console.ReadLine());

        string space = new string (' ', glassesHeight);
        string frame = new string('*', 2*glassesHeight);
        string lense = new string('/', (2*glassesHeight-2));
        string bridge = new string('|', glassesHeight);

        //the upper frame
        Console.WriteLine("{0}{1}{0}", frame, space);
        
        // lenses
        if ((glassesHeight - 2) == 1)
        {
            Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', lense, bridge);
        }
        else
        {
            for (int i = 1; i < glassesHeight - 2; i++)
            {


                if (i == ((glassesHeight-2) + 1) / 2)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', lense, bridge); //bridge
                }

                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', lense, space);
            }
        }
        //the lower frame
        Console.WriteLine("{0}{1}{0}", frame, space);
    }
}