namespace School.Tests
{
    using NUnit.Framework;
    using School.Models;

    [TestFixture]
    [Category("School tests")]
    public class SchoolTests
    {
        [Test]
        public void SchoolList_IsNotNull_ShouldReturnTrue()
        {
            //Assert
            var school = new School();

            //Assert
            Assert.IsNotNull(school);
        }
    }
}
