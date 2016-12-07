using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Factories;

namespace SchoolSystem.Framework.Core.Handlers
{
    public class StudentListAllMarksHandler : Handler
    {
        public StudentListAllMarksHandler(ICommandFactory commandFactory)
            : base(commandFactory)
        {
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "StudentListMarks";
        }

        protected override ICommand Handle()
        {
            return this.CommandFactory.GetStudentListMarksCommand();
        }
    }
}
