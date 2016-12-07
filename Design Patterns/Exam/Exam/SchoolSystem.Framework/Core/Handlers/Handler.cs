using System;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Factories;

namespace SchoolSystem.Framework.Core.Handlers
{
    public abstract class Handler : IHandler
    {
        private ICommandFactory commandFactory;

        public Handler(ICommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        protected ICommandFactory CommandFactory
        {
            get { return this.commandFactory; }
        }

        private IHandler Successor { get; set; }

        public void SetSuccessor(IHandler successor)
        {
            this.Successor = successor;
        }

        public ICommand GenerateCommand(string command)
        {
            if (this.CanHandle(command))
            {
                return this.Handle();
            }

            if (this.Successor != null)
            {
                return this.Successor.GenerateCommand(command);
            }

            throw new ArgumentException("The passed command is not found!");
        }

        protected abstract bool CanHandle(string commandName);

        protected abstract ICommand Handle();
    }
}
