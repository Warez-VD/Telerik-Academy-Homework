using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Factories;
using SchoolSystem.Framework.DataStorage;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateStudentCommand : ICommand
    {
        private IStudentFactory factory;
        private IStorage studentsData;

        public CreateStudentCommand(IStudentFactory factory, IStorage studentsData)
        {
            this.factory = factory;
            this.studentsData = studentsData;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var grade = (Grade)int.Parse(parameters[2]);

            var student = this.factory.CreateStudent(firstName, lastName, grade);
            var currentId = this.studentsData.Students.Count;
            this.studentsData.Students.Add(currentId, student);
            var result = $"A new student with name {firstName} {lastName}, grade {grade} and ID {currentId} was created.";
            return result;
        }
    }
}
