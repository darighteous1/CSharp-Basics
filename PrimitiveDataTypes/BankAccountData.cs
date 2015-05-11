using System;

class BankAccountData
{
    static void Main()
    {
        string fullName = "Гошо von Почивка";
        uint balance = 10;
        string bankName = "Bank of Pochivka";
        string iban = "BG32 BOFP 1234 4444 5555";
        ulong ccNum1 = 4916976864492778;
        ulong ccNum2 = 5176775839745852;
        ulong ccNum3 = 378701580591516;

        Console.WriteLine(fullName);
        Console.WriteLine(balance);
        Console.WriteLine(bankName);
        Console.WriteLine(iban);
        Console.WriteLine(ccNum1);
        Console.WriteLine(ccNum2);
        Console.WriteLine(ccNum3);
    }
}