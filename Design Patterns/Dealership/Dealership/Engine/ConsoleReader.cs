using System;
using Dealership.Contracts;

namespace Dealership.Engine
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
