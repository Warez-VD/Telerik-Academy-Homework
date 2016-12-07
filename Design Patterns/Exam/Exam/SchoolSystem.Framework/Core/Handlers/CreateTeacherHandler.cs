using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Factories;

namespace SchoolSystem.Framework.Core.Handlers
{
    public class CreateTeacherHandler : Handler
    {
        private ITeacherFactory teacherFactory;
        private IMarkFactory markFactory;

        public CreateTeacherHandler(ICommandFactory commandFactory, ITeacherFactory teacherFactory, IMarkFactory markFactory)
            : base(commandFactory)
        {
            this.teacherFactory = teacherFactory;
            this.markFactory = markFactory;
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "CreateTeacher";
        }

        protected override ICommand Handle()
        {
            return this.CommandFactory.GetCreateTeacherCommand(teacherFactory, markFactory);
        }
    }
}
