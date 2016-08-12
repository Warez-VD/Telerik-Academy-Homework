namespace School.Models
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Course : ICourse
    {
        private ICollection<IStudent> studentsList;
        private const int MaxStudents = 30;

        public Course()
        {
            this.studentsList = new List<IStudent>();
        }

        public void JoinCourse(IStudent student)
        {
            if (this.CanStudentJoinCourse(student))
            {
                this.studentsList.Add(student);
            }
        }

        public void LeaveCourse(IStudent student)
        {
            this.studentsList.Remove(student);
        }

        public bool CanStudentJoinCourse(IStudent student)
        {
            if (this.studentsList.Count >= MaxStudents)
            {
                return false;
            }

            return true;
        }
    }
}
