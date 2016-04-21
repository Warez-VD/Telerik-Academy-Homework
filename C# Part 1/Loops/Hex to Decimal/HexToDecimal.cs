using System;

class HexToDecimal
{
    static void Main()
    {
        string hexNum = Console.ReadLine();
        long hexNumber = 0;
        int counter = 0;
        long result = 0;
        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            switch (hexNum[i])
            {
                case '0':
                    hexNumber = 0;
                    break;
                case '1':
                    hexNumber = 1;
                    break;
                case '2':
                    hexNumber = 2;
                    break;
                case '3':
                    hexNumber = 3;
                    break;
                case '4':
                    hexNumber = 4;
                    break;
                case '5':
                    hexNumber = 5;
                    break;
                case '6':
                    hexNumber = 6;
                    break;
                case '7':
                    hexNumber = 7;
                    break;
                case '8':
                    hexNumber = 8;
                    break;
                case '9':
                    hexNumber = 9;
                    break;
                case 'A':
                    hexNumber = 10;
                    break;
                case 'B':
                    hexNumber = 11;
                    break;
                case 'C':
                    hexNumber = 12;
                    break;
                case 'D':
                    hexNumber = 13;
                    break;
                case 'E':
                    hexNumber = 14;
                    break;
                case 'F':
                    hexNumber = 15;
                    break;
                default:
                    Console.WriteLine("invalid symbol");
                    break;
            }
            result += hexNumber * (long)Math.Pow(16, counter);
            counter++;
        }
        Console.WriteLine(result);
    }
}

