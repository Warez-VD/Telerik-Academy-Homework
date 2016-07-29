namespace ExtensionMethods
{
    using System;
    using System.Text;

    public class MainProgram
    {
        static void Main()
        {
            //Task 1
            var builder = new StringBuilder();
            builder.Append("Hello lovely C#!");
            var result = builder.Substring(6, 6);
            Console.WriteLine(result);

            //Task 2
            var myList = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myList[i] = i + 1;
            }

            Console.WriteLine(string.Join(" ", myList));

            Console.WriteLine(myList.MySum());
            Console.WriteLine(myList.MyProduct());
            Console.WriteLine(myList.MyMin());
            Console.WriteLine(myList.MyMax());
            Console.WriteLine(myList.MyAverage());
        }
    }
}
