using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using SchoolSystem.Framework.DataStorage;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Tests.Commands.TeacherAddMarkCommandTests
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        public void AddNewMarkInStudentMarkCollection()
        {
            var parameters = new List<string>() { "0", "0", "3" };
            var mockedMark = new Mock<IMark>();
            var mockedStudent = new Mock<IStudent>();
            mockedStudent.Setup(x => x.Marks).Returns(new List<IMark>());
            var mockedTeacher = new Mock<ITeacher>();
            mockedTeacher.Setup(x => x.AddMark(mockedStudent.Object, float.Parse(parameters[2]))).Callback(() => mockedStudent.Object.Marks.Add(mockedMark.Object));
            var mockedStorage = new Mock<IStorage>();
            mockedStorage.Setup(x => x.Students).Returns(new Dictionary<int, IStudent>() { { 0, mockedStudent.Object } });
            mockedStorage.Setup(x => x.Teachers).Returns(new Dictionary<int, ITeacher>() { { 0, mockedTeacher.Object } });
            
            var teacherAddMarkCommand = new TeacherAddMarkCommand(mockedStorage.Object);
            var expected = mockedStorage.Object.Students[0].Marks.Count + 1;

            teacherAddMarkCommand.Execute(parameters);

            Assert.AreEqual(expected, mockedStorage.Object.Students[0].Marks.Count);
        }

        [Test]
        public void AddMarkMethod_MustBeCalledOnce()
        {
            var parameters = new List<string>() { "0", "0", "3" };
            var mockedStudent = new Mock<IStudent>();
            var mockedTeacher = new Mock<ITeacher>();
            var mockedStorage = new Mock<IStorage>();
            mockedStorage.Setup(x => x.Students).Returns(new Dictionary<int, IStudent>() { { 0, mockedStudent.Object } });
            mockedStorage.Setup(x => x.Teachers).Returns(new Dictionary<int, ITeacher>() { { 0, mockedTeacher.Object } });
            var teacherAddMarkCommand = new TeacherAddMarkCommand(mockedStorage.Object);

            var actual = teacherAddMarkCommand.Execute(parameters);

            mockedTeacher.Verify(x => x.AddMark(mockedStudent.Object, float.Parse(parameters[2])), Times.Once);
        }

        [Test]
        public void ReturnCorrectStringResult()
        {
            var parameters = new List<string>() { "0", "0", "3" };
            var mockedStudent = new Mock<IStudent>();
            mockedStudent.Setup(x => x.FirstName).Returns("John");
            mockedStudent.Setup(x => x.LastName).Returns("Smith");
            var mockedTeacher = new Mock<ITeacher>();
            mockedTeacher.Setup(x => x.FirstName).Returns("Tara");
            mockedTeacher.Setup(x => x.LastName).Returns("Johnson");
            mockedTeacher.Setup(x => x.Subject).Returns(Subject.Bulgarian);
            var mockedStorage = new Mock<IStorage>();
            mockedStorage.Setup(x => x.Students).Returns(new Dictionary<int, IStudent>() { { 0, mockedStudent.Object } });
            mockedStorage.Setup(x => x.Teachers).Returns(new Dictionary<int, ITeacher>() { { 0, mockedTeacher.Object } });

            var teacherAddMarkCommand = new TeacherAddMarkCommand(mockedStorage.Object);
            var expected = $"Teacher {mockedTeacher.Object.FirstName} {mockedTeacher.Object.LastName} added mark {parameters[2]} to student {mockedStudent.Object.FirstName} {mockedStudent.Object.LastName} in {mockedTeacher.Object.Subject}.";

            var actual = teacherAddMarkCommand.Execute(parameters);

            Assert.AreEqual(expected, actual);
        }
    }
}
