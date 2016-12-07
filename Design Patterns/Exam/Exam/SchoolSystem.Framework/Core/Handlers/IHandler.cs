using SchoolSystem.Framework.Core.Commands.Contracts;

namespace SchoolSystem.Framework.Core.Handlers
{
    public interface IHandler
    {
        void SetSuccessor(IHandler successor);

        ICommand GenerateCommand(string commandName);
    }
}
