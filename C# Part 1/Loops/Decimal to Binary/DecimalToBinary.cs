using System;

class DecimalToBinary
{
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        long number = decNumber;
        string binary = "";
        if (number == 0)
        {
            binary = binary + number.ToString();
        }
        while (number > 0)
        {
            long reminder = number % 2;
            binary = binary + reminder.ToString();
            number /= 2;
        }
        char[] arr = binary.ToCharArray();
        Array.Reverse(arr);
        string newBin = new string(arr);
        Console.WriteLine(Convert.ToString(decNumber, 2));
    }
}

