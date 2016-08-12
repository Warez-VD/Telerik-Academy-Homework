namespace School.Tests
{
    using System;
    using NUnit.Framework;
    using School.Models;

    [TestFixture]
    [Category("Student tests")]
    public class StudentTests
    {
        [Test]
        public void IsNotNameValid_EmptyOrNull_ShouldReturnException()
        {
            //Arrange
            string name = string.Empty;
            var student = new Student();

            //Act
            Assert.Catch<ArgumentNullException>(() => student.IsNotValidName(name));
        }

        [Test]
        public void IsUniqueNumberOutOfRange_OutOfRangeValue_ShouldThrowException()
        {
            //Arrange
            var student = new Student();
            int uniqueNumber = 10;

            //Act
            Assert.Throws<ArgumentException>(() => student.IsUniqueNumberOutOfRange(uniqueNumber));
        }

        [Test]
        public void Name_ValidName_ShouldReturnTrue()
        {
            //Arrange
            var student = new Student("John", 15000);
            var expectedName = "John";

            //Act
            var actualName = student.Name;

            //Assert
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void UniqueNumber_ValidNumber_ShouldReturnTrue()
        {
            //Arrange
            var student = new Student("John", 15000);
            var expectedUniqueNumber = 15000;

            //Act
            var actualUniqueNumber = student.UniqueNumber;

            //Assert
            Assert.AreEqual(expectedUniqueNumber, actualUniqueNumber);
        }
    }
}
