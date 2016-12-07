using Dealership.DataStorage;
using System;

namespace Dealership.Engine.Handlers
{
    public abstract class Handler : IHandler
    {
        private const string InvalidCommand = "Invalid command!";

        public Handler()
        {
        }

        private IHandler Successor { get; set; }

        public void SetSuccessor(IHandler successor)
        {
            this.Successor = successor;
        }

        public string HandleCommand(ICommand command, IStorage data)
        {
            if (this.CanHandle(command.Name))
            {
                return this.Handle(command, data);
            }

            if (this.Successor != null)
            {
                return this.Successor.HandleCommand(command, data);
            }

            return string.Format(InvalidCommand, command.Name);
        }

        protected abstract bool CanHandle(string commandName);

        protected abstract string Handle(ICommand command, IStorage data);

        protected void ValidateRange(int? value, int min, int max, string message)
        {
            if (value < min || value >= max)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
