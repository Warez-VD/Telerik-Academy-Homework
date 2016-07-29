namespace CorrectBrackets
{
    using System;

    class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Check(input);
        }
        
        public static void Check(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    counter++;
                }
                else if (text[i] == ')')
                {
                    counter--;
                }

                if (counter < 0)
                {
                    break;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

        }
    }
}
