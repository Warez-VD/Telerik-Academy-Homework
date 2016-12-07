using Dealership.DataStorage;

namespace Dealership.Engine.Handlers
{
    public interface IHandler
    {
        void SetSuccessor(IHandler successor);

        string HandleCommand(ICommand command, IStorage data);
    }
}
