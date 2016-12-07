using System.Collections.Generic;
using SchoolSystem.Framework.Models.Contracts;

namespace SchoolSystem.Framework.DataStorage
{
    public class DataStorage : IStorage
    {
        private IDictionary<int, IStudent> students;
        private IDictionary<int, ITeacher> teachers;

        public DataStorage()
        {
            this.students = new Dictionary<int, IStudent>();
            this.teachers = new Dictionary<int, ITeacher>();
        }

        public IDictionary<int, IStudent> Students
        {
            get
            {
                return this.students;
            }
        }

        public IDictionary<int, ITeacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        }
    }
}
