using System;

class CompanyInfo
{
    static void Main()
    {
        string cName = Console.ReadLine();
        string cAddress = Console.ReadLine();
        string pNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string mFirstName = Console.ReadLine();
        string mLastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string mPhone = Console.ReadLine();
            
        Console.WriteLine(cName);
        Console.WriteLine("Address: " + cAddress);
        Console.WriteLine("Tel. " + pNumber);
        if (faxNumber == "")
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: " + faxNumber);
        }
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", mFirstName, mLastName, age, mPhone);
    }
}

