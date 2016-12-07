using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using SchoolSystem.Framework.DataStorage;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Core.Commands;

namespace SchoolSystem.Tests.Commands.RemoveStudentCommandTests
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        public void RemoveStudent_InStorageCollection()
        {
            var parameters = new List<string>() { "0" };
            var mockedStorage = new Mock<IStorage>();
            mockedStorage.Setup(x => x.Students).Returns(new Dictionary<int, IStudent>() { { 0, It.IsAny<IStudent>() } });
            var removeStudentCommand = new RemoveStudentCommand(mockedStorage.Object);
            var expected = mockedStorage.Object.Students.Count - 1;

            removeStudentCommand.Execute(parameters);

            Assert.AreEqual(expected, mockedStorage.Object.Students.Count);
        }

        [Test]
        public void Return_CorrectStringValue()
        {
            var parameters = new List<string>() { "0" };
            var mockedStorage = new Mock<IStorage>();
            mockedStorage.Setup(x => x.Students).Returns(new Dictionary<int, IStudent>() { { 0, It.IsAny<IStudent>() } });
            var createStudentCommand = new RemoveStudentCommand(mockedStorage.Object);
            string expected = $"Student with ID {0} was sucessfully removed.";

            var actual = createStudentCommand.Execute(parameters);

            Assert.AreEqual(expected, actual);
        }
    }
}
