using System;
using System.Linq;

class NumbersAsWords
{
    static void Main(string[] args)
    {
        string[] lesserNumbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", 
                                     "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
                                     "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        Console.Write("Please, enter a number between 0 and 999 inclusive:");

        int input;
        bool validInputCheck = Int32.TryParse(Console.ReadLine(), out input);
        
        if (validInputCheck == false)
        {
            Console.WriteLine("ARGH! THOU SHALL ENTER NUMBER!!!");
            return;
        }
        
        if (input < 0 || input > 999)
        {
            Console.WriteLine("ARGH! WRONG NUMBER!!!");
            return;
        }

        int indexLesserNums = input % 10;
        int indexTens = input / 10 - 2;
        string capitalFirstLetter;

        if (input >= 100 && input % 100 == 0)
        {
            capitalFirstLetter = lesserNumbers[input / 100].First().ToString().ToUpper() + lesserNumbers[input / 100].Substring(1);
            Console.WriteLine("{0} hundred", capitalFirstLetter);
            return;
        }

        if (input < 20)
        {
            capitalFirstLetter = lesserNumbers[input].First().ToString().ToUpper() + lesserNumbers[input].Substring(1);
            Console.WriteLine(capitalFirstLetter);
        }
        else if (input >= 20 && input < 100)
        {
            capitalFirstLetter = tens[indexTens].First().ToString().ToUpper() + tens[indexTens].Substring(1);
            if (input % 10 == 0)
            {
                Console.WriteLine(capitalFirstLetter);
            }
            else
            {
                Console.WriteLine("{0} {1}", capitalFirstLetter, lesserNumbers[indexLesserNums]);
            }
        }
        else if (input >= 100 && input < 1000)
        {
            int indexHundreds = input / 100;
            int indexLessThanTwenty = input % 100;
            capitalFirstLetter = lesserNumbers[indexHundreds].First().ToString().ToUpper() + lesserNumbers[indexHundreds].Substring(1);

            if (input % 100 < 20)
            {
                Console.WriteLine("{0} hundred and {1}", capitalFirstLetter, lesserNumbers[indexLessThanTwenty]);
            }
            else
            {
                int indexBiggerThanTwenty = (input % 100 / 10) - 2;
                Console.WriteLine("{0} hundred and {1} {2}", capitalFirstLetter, tens[indexBiggerThanTwenty], lesserNumbers[indexLesserNums]);
            }
        }
    }
}