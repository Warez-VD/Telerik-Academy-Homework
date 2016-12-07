using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.DataStorage;

namespace SchoolSystem.Framework.Core.Commands
{
    public class RemoveStudentCommand : ICommand
    {
        private IStorage studentsData;

        public RemoveStudentCommand(IStorage studentsData)
        {
            this.studentsData = studentsData;
        }

        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            this.studentsData.Students.Remove(studentId);
            return $"Student with ID {studentId} was sucessfully removed.";
        }
    }
}
