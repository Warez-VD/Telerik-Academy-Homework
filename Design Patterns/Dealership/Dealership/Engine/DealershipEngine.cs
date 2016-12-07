using System.Collections.Generic;
using Dealership.Contracts;
using Dealership.DataStorage;

namespace Dealership.Engine
{
    public sealed class DealershipEngine : IEngine
    {
        private ICommandExecutor commandExecutor;
        private IReportPrinter reportPrinter;
        private IStorage data;

        public DealershipEngine(ICommandExecutor commandExecutor, IReportPrinter reportPrinter, IStorage dataStorage)
        {
            this.commandExecutor = commandExecutor;
            this.reportPrinter = reportPrinter;
            this.data = dataStorage;
        }

        public void Start()
        {
            var commands = this.commandExecutor.ReadCommands();
            var commandResult = this.commandExecutor.ProcessCommands(commands, this.data);
            this.reportPrinter.PrintReports(commandResult);
        }
    }
}
