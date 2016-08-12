namespace School.Interfaces
{
    using System.Collections.Generic;

    public interface ICourse
    {
        void JoinCourse(IStudent student);
        void LeaveCourse(IStudent student);
    }
}
