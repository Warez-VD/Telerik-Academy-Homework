using System;
using System.Collections.Generic;
using Dealership.Contracts;
using Dealership.Engine.Handlers;
using Dealership.DataStorage;

namespace Dealership.Engine
{
    public class CommandExecutor : ICommandExecutor
    {
        private const string UserNotLogged = "You are not logged! Please login first!";

        private IReader reader;
        private IHandler handler;
        
        public CommandExecutor(IReader reader, IHandler handler)
        {
            this.reader = reader;
            this.handler = handler;
        }

        public IList<string> ProcessCommands(IList<ICommand> commands, IStorage data)
        {
            var reports = new List<string>();

            foreach (var command in commands)
            {
                try
                {
                    var report = this.ProcessSingleCommand(command, data);
                    reports.Add(report);
                }
                catch (Exception ex)
                {
                    reports.Add(ex.Message);
                }
            }

            return reports;
        }

        public IList<ICommand> ReadCommands()
        {
            var commands = new List<ICommand>();

            var currentLine = this.reader.Read();

            while (!string.IsNullOrEmpty(currentLine))
            {
                var currentCommand = new Command(currentLine);
                commands.Add(currentCommand);

                currentLine = this.reader.Read();
            }

            return commands;
        }

        private string ProcessSingleCommand(ICommand command, IStorage data)
        {
            if (command.Name != "RegisterUser" && command.Name != "Login")
            {
                if (data.LoggedUser == null)
                {
                    return UserNotLogged;
                }
            }

            var result = this.handler.HandleCommand(command, data);
            return result;
        }
    }
}
