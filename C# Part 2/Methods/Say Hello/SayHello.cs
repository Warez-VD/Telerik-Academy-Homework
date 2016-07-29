using System;

namespace SayHello
{
    class SayHello
    {
        static void Main()
        {
            string name = Console.ReadLine();
            Say(name);
        }
        
        public static void Say(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
