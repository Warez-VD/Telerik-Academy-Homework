using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Factories;

namespace SchoolSystem.Framework.Core.Handlers
{
    public class RemoveTeacherHandler : Handler
    {
        public RemoveTeacherHandler(ICommandFactory commandFactory)
            : base(commandFactory)
        {
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "RemoveTeacher";
        }

        protected override ICommand Handle()
        {
            return this.CommandFactory.GetRemoveTeacherCommand();
        }
    }
}
