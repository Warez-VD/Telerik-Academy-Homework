using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Factories;
using SchoolSystem.Framework.DataStorage;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateTeacherCommand : ICommand
    {
        private ITeacherFactory teacherFactory;
        private IMarkFactory markFactory;
        private IStorage teachersData;

        public CreateTeacherCommand(ITeacherFactory teacherFactory, IMarkFactory markFactory, IStorage teachersData)
        {
            this.teacherFactory = teacherFactory;
            this.markFactory = markFactory;
            this.teachersData = teachersData;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var subject = (Subject)int.Parse(parameters[2]);
            
            var teacher = this.teacherFactory.CreateTeacher(firstName, lastName, subject, markFactory);
            var currentId = this.teachersData.Teachers.Count;
            this.teachersData.Teachers.Add(currentId, teacher);

            return $"A new teacher with name {firstName} {lastName}, subject {subject} and ID {currentId} was created.";
        }
    }
}
