using System;

class FriquentNumber
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        int counter = 0;
        int maxCounter = 0;
        int number = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                }
            }

            if (counter > maxCounter)
            {
                number = i;
                maxCounter = counter;
            }
            counter = 0;
        }
        Console.WriteLine("{0} ({1} times)", array[number], maxCounter);
    }
}

