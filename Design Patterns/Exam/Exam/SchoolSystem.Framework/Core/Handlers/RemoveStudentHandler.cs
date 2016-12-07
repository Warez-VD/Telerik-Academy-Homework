using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Factories;

namespace SchoolSystem.Framework.Core.Handlers
{
    public class RemoveStudentHandler : Handler
    {
        public RemoveStudentHandler(ICommandFactory commandFactory)
            : base(commandFactory)
        {
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "RemoveStudent";
        }

        protected override ICommand Handle()
        {
            return this.CommandFactory.GetRemoveStudentCommand();
        }
    }
}
