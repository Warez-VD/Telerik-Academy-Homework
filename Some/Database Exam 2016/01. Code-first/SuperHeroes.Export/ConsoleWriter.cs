using System;

namespace SuperHeroes.Export
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
