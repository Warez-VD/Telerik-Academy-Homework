using System;

namespace Dealership.Engine
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
