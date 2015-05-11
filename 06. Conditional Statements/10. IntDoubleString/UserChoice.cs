using System;

class UserChoice
{
    static void Main()
    {
        string menu = "Please, choose a type:\n1 --> int\n2 --> double\n3 --> string";
        Console.WriteLine(menu);
        int choice;

        bool check = Int32.TryParse(Console.ReadLine(), out choice);
        if (check == false)
        {
            Console.WriteLine("Error!");
            return;
        }

        switch (choice)
        {
            case 1:
                Console.Write("Please, enter an integer: ");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(inputInt+1);
                break;
            case 2:
                Console.Write("Please, enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble+1);
                break;
            case 3:
                Console.Write("Please, enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine(inputString+'*');
                break;
            default:
                Console.WriteLine("Wrong input!");
                break;
        }

    }
}