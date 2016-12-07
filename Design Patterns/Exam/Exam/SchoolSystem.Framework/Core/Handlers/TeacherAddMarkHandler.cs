using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Factories;

namespace SchoolSystem.Framework.Core.Handlers
{
    public class TeacherAddMarkHandler : Handler
    {
        public TeacherAddMarkHandler(ICommandFactory commandFactory)
            : base(commandFactory)
        {
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "TeacherAddMark";
        }

        protected override ICommand Handle()
        {
            return this.CommandFactory.GetTeacherAddMarkCommand();
        }
    }
}
