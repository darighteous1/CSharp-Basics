using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhoneNumber = Console.ReadLine();
        string managerFullName = managerFirstName + managerLastName;

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. +{0}", companyPhoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber != "" ? faxNumber : "(no fax)");
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0}, (age: {1}, tel. +{2})", managerFullName, managerAge, managerPhoneNumber);

    }
}