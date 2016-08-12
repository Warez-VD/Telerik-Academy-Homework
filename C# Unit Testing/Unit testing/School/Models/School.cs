namespace School.Models
{
    using System.Collections.Generic;

    using Interfaces;

    public class School
    {
        private ICollection<ICourse> courses;

        public School()
        {
            this.courses = new List<ICourse>();
        }
    }
}
