using System;
using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.DataStorage;

namespace SchoolSystem.Framework.Core.Commands
{
    public class RemoveTeacherCommand : ICommand
    {
        private IStorage teachersData;

        public RemoveTeacherCommand(IStorage teachersData)
        {
            this.teachersData = teachersData;
        }

        public string Execute(IList<string> parameters)
        {
            var teacherId = int.Parse(parameters[0]);

            if (!this.teachersData.Teachers.ContainsKey(teacherId))
            {
                throw new ArgumentException("The given key was not present in the dictionary.");
            }

            this.teachersData.Teachers.Remove(teacherId);
            return $"Teacher with ID {teacherId} was sucessfully removed.";
        }
    }
}
