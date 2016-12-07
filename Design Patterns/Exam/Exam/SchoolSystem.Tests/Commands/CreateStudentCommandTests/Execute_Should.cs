using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using SchoolSystem.Framework.Factories;
using SchoolSystem.Framework.Models.Enums;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.DataStorage;

namespace SchoolSystem.Tests.Commands.CreateStudentCommandTests
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        public void AddNewStudent_MustBeCalledOnce()
        {
            var parameters = new List<string>() { "Pesho", "Peshev", "11" };
            var mockedStorage = new Mock<IStorage>();
            mockedStorage.Setup(x => x.Students).Returns(new Dictionary<int, IStudent>());
            var mockedStudentsFactory = new Mock<IStudentFactory>();
            var createStudentCommand = new CreateStudentCommand(mockedStudentsFactory.Object, mockedStorage.Object);

            createStudentCommand.Execute(parameters);

            mockedStudentsFactory.Verify(x => x.CreateStudent(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Grade>()), Times.Once);
        }

        [Test]
        public void AddNewStudent_InStorageCollection()
        {
            var parameters = new List<string>() { "Pesho", "Peshev", "11" };
            var mockedStorage = new Mock<IStorage>();
            mockedStorage.Setup(x => x.Students).Returns(new Dictionary<int, IStudent>());
            var mockedStudentsFactory = new Mock<IStudentFactory>();
            var createStudentCommand = new CreateStudentCommand(mockedStudentsFactory.Object, mockedStorage.Object);
            var expected = mockedStorage.Object.Students.Count + 1;

            createStudentCommand.Execute(parameters);

            Assert.AreEqual(expected, mockedStorage.Object.Students.Count);
        }

        [Test]
        public void Return_CorrectStringValue()
        {
            var parameters = new List<string>() { "Pesho", "Peshev", "11" };
            var mockedStorage = new Mock<IStorage>();
            mockedStorage.Setup(x => x.Students).Returns(new Dictionary<int, IStudent>());
            var mockedStudentsFactory = new Mock<IStudentFactory>();
            var createStudentCommand = new CreateStudentCommand(mockedStudentsFactory.Object, mockedStorage.Object);
            string expected = $"A new student with name {parameters[0]} {parameters[1]}, grade {(Grade)int.Parse(parameters[2])} and ID {0} was created.";

            var actual = createStudentCommand.Execute(parameters);

            Assert.AreEqual(expected, actual);
        }
    }
}
