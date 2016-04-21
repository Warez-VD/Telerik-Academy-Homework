using System;

class GCD
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int firstNum = 0;
        int secondNum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
            if (i == 0)
            {
                firstNum = number;
            }
            else
            {
                secondNum = number;
            }
        }
        int max = Math.Abs(Math.Max(firstNum, secondNum));
        int min = Math.Abs(Math.Min(firstNum, secondNum));
        int reminder = 0;

        if (max == 0)
        {
            Console.WriteLine(min);
        }
        else if (min == 0)
        {
            Console.WriteLine(max);
        }
        else if (max == min)
        {
            Console.WriteLine(max);
        }
        else
        {
            reminder = max % min;
            if (reminder == 0)
            {
                Console.WriteLine(min);
            }
            else
            {
                int temp = 0;
                while (reminder > 0)
                {
                    temp = min % reminder;
                    min = reminder;
                    if (temp > 0)
                    {
                        reminder = temp;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(reminder);
            }
        }
    }
}

