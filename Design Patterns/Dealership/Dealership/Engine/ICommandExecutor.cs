using Dealership.DataStorage;
using System.Collections.Generic;

namespace Dealership.Engine
{
    public interface ICommandExecutor
    {
        IList<ICommand> ReadCommands();

        IList<string> ProcessCommands(IList<ICommand> commands, IStorage data);
    }
}
