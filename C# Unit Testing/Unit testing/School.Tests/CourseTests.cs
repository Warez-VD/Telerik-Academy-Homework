namespace School.Tests
{
    using System.Linq;
    using NUnit.Framework;

    using School.Models;

    [TestFixture]
    [Category("Course tests")]
    public class CourseTests
    {
        [Test]
        public void CanStudentJoinCourse_IfCourseCountIsLessThan30_ShouldReturnTrue()
        {
            //Assert
            var course = new Course();
            var student = new Student();

            //Act
            var actualResult = course.CanStudentJoinCourse(student);

            //Assert
            Assert.IsTrue(actualResult);
        }

        [Test]
        public void CanStudentJoinCourse_IfCourseCountIsGreaterThanOrEqualTo30_ShouldReturnTrue()
        {
            //Assert
            var course = new Course();
            var student = new Student();
            for (int i = 0; i < 30; i++)
            {
                course.JoinCourse(new Student());
            }

            //Act
            var actualResult = course.CanStudentJoinCourse(student);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void CourseList_IsNotNull_ShouldReturnTrue()
        {
            //Assert
            var course = new Course();

            //Assert
            Assert.IsNotNull(course);
        }
    }
}
