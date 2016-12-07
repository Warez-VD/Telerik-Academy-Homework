using SchoolSystem.Framework.Core.Commands.Contracts;

namespace SchoolSystem.Framework.Factories
{
    public interface ICommandFactory
    {
        ICommand GetCreateStudentCommand(IStudentFactory factory);

        ICommand GetCreateTeacherCommand(ITeacherFactory teacherFactory, IMarkFactory markFactory);

        ICommand GetRemoveStudentCommand();

        ICommand GetRemoveTeacherCommand();

        ICommand GetStudentListMarksCommand();

        ICommand GetTeacherAddMarkCommand();
    }
}
