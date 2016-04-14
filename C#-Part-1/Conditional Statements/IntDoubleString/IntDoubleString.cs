using System;

class IntDoubleString
{
    static void Main()
    {
        string type = Console.ReadLine();
        string variable = Console.ReadLine();
        int iNum;
        double dNum;
        switch (type)
        {
            case "integer":
                iNum = int.Parse(variable);
                Console.WriteLine(iNum + 1);
                break;
            case "real":
                dNum = double.Parse(variable);
                Console.WriteLine("{0:0.00}", dNum + 1);
                break;
            case "text":
                Console.WriteLine(variable + "*");
                break;
            default:
                Console.WriteLine("Invalid type");
                break;
        }
    }
}

