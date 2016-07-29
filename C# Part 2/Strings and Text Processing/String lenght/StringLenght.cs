namespace StringLenght
{
    using System;

    class StringLenght
    {
        static void Main()
        {
            string input = Console.ReadLine();
            input = input.Replace(@"\", string.Empty);
            if (input.Length > 20)
            {
                //string subString = input.Substring(0, 20);
                //input = subString;
                input.ToLower();
            }
            else
            {
                string replace = string.Empty;
                for (int i = 0; i < 20 - input.Length; i++)
                {
                    replace += '*';
                }
                
                input += replace;
            }
            Console.WriteLine(input);
        }
    }
}
