using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Factories;

namespace SchoolSystem.Framework.Core.Handlers
{
    public class CreateStudentHandler : Handler
    {
        private IStudentFactory studentFactory;

        public CreateStudentHandler(ICommandFactory commandFactory, IStudentFactory studentFactory)
            : base(commandFactory)
        {
            this.studentFactory = studentFactory;
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "CreateStudent";
        }

        protected override ICommand Handle()
        {
            return this.CommandFactory.GetCreateStudentCommand(this.studentFactory);
        }
    }
}
