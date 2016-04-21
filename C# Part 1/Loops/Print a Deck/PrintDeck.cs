using System;
using System.Text;

class PrintDeck
{
    static void Main()
    {
        string cardSymbol = Console.ReadLine();
        int cycleNumber = 0;
        switch (cardSymbol)
        {
            case "2":
                cycleNumber = 2;
                break;
            case "3":
                cycleNumber = 3;
                break;
            case "4":
                cycleNumber = 4;
                break;
            case "5":
                cycleNumber = 5;
                break;
            case "6":
                cycleNumber = 6;
                break;
            case "7":
                cycleNumber = 7;
                break;
            case "8":
                cycleNumber = 8;
                break;
            case "9":
                cycleNumber = 9;
                break;
            case "10":
                cycleNumber = 10;
                break;
            case "J":
                cycleNumber = 11;
                break;
            case "Q":
                cycleNumber = 12;
                break;
            case "K":
                cycleNumber = 13;
                break;
            case "A":
                cycleNumber = 14;
                break;
            default:
                Console.WriteLine("invalid card sign");
                break;
        }


        for (int i = 2; i <= cycleNumber; i++)
        {
            switch (i)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                    break;
                case 11:
                    Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                    break;
                case 12:
                    Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                    break;
                case 13:
                    Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                    break;
                case 14:
                    Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                    break;
                default:
                    Console.WriteLine("Invalid card");
                    break;
            }
        }
    }
}

