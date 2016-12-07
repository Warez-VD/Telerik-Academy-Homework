using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.DataStorage;

namespace SchoolSystem.Framework.Core.Commands
{
    public class StudentListMarksCommand : ICommand
    {
        private IStorage studentsData;

        public StudentListMarksCommand(IStorage studentsData)
        {
            this.studentsData = studentsData;
        }

        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            var student = this.studentsData.Students[studentId];
            return student.ListMarks();
        }
    }
}
