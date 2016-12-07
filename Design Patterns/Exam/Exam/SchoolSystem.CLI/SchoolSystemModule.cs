using System.IO;
using System.Reflection;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Interception.Infrastructure.Language;
using Ninject.Modules;

using SchoolSystem.Cli.Configuration;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Handlers;
using SchoolSystem.Framework.Core.Providers;
using SchoolSystem.Framework.DataStorage;
using SchoolSystem.Framework.Factories;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models;

namespace SchoolSystem.Cli
{
    public class SchoolSystemModule : NinjectModule
    {
        private const string CreateStudentCommandName = "CreateStudentCommand";
        private const string CreateTeacherCommandName = "CreateTeacherCommand";
        private const string RemoveStudentCommandName = "RemoveStudentCommand";
        private const string RemoveTeacherCommandName = "RemoveTeacherCommand";
        private const string StudentListMarksCommandName = "StudentListMarksCommand";
        private const string TeacherAddMarkCommandName = "TeacherAddMarkCommand";

        private const string CreateStudentHandlerName = "CreateStudentHandler";
        private const string CreateTeacherHandlerName = "CreateTeacherHandler";
        private const string RemoveStudentHandlerName = "RemoveStudentHandler";
        private const string RemoveTeacherHandlerName = "RemoveTeacherHandler";
        private const string StudentListAllMarksHandlerName = "StudentListAllMarksHandler";
        private const string TeacherAddMarkHandlerName = "TeacherAddMark";

        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .SelectAllClasses()
                .BindDefaultInterface();
            });

            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();
            if (configurationProvider.IsTestEnvironment)
            {
                this.Bind<IMarkFactory>().ToFactory().InSingletonScope().Intercept().With<MeasureInterceptor>();
                this.Bind<IStudentFactory>().ToFactory().InSingletonScope().Intercept().With<MeasureInterceptor>();
                this.Bind<ICommandFactory>().ToFactory().InSingletonScope().Intercept().With<MeasureInterceptor>();
            }
            else
            {
                this.Bind<IMarkFactory>().ToFactory().InSingletonScope();
                this.Bind<IStudentFactory>().ToFactory().InSingletonScope();
                this.Bind<ICommandFactory>().ToFactory().InSingletonScope();
            }

            this.Bind<IStudent>().To<Student>();
            this.Bind<IParser>().To<CommandParserProvider>();
            this.Bind<IReader>().To<ConsoleReaderProvider>();
            this.Bind<IWriter>().To<ConsoleWriterProvider>();
            this.Bind<IStorage>().To<DataStorage>().InSingletonScope();

            this.Bind<ITeacherFactory>().ToFactory().InSingletonScope();

            this.Bind<ICommand>().To<CreateStudentCommand>().Named(CreateStudentCommandName);
            this.Bind<ICommand>().To<CreateTeacherCommand>().Named(CreateTeacherCommandName);
            this.Bind<ICommand>().To<RemoveStudentCommand>().Named(RemoveStudentCommandName);
            this.Bind<ICommand>().To<RemoveTeacherCommand>().Named(RemoveTeacherCommandName);
            this.Bind<ICommand>().To<StudentListMarksCommand>().Named(StudentListMarksCommandName);
            this.Bind<ICommand>().To<TeacherAddMarkCommand>().Named(TeacherAddMarkCommandName);

            this.Bind<IHandler>().To<CreateStudentHandler>().Named(CreateStudentHandlerName);
            this.Bind<IHandler>().To<CreateTeacherHandler>().Named(CreateTeacherHandlerName);
            this.Bind<IHandler>().To<RemoveStudentHandler>().Named(RemoveStudentHandlerName);
            this.Bind<IHandler>().To<RemoveTeacherHandler>().Named(RemoveTeacherHandlerName);
            this.Bind<IHandler>().To<StudentListAllMarksHandler>().Named(StudentListAllMarksHandlerName);
            this.Bind<IHandler>().To<TeacherAddMarkHandler>().Named(TeacherAddMarkHandlerName);
            this.Bind<IHandler>().ToMethod(context =>
            {
                var createStudentHandler = context.Kernel.Get<IHandler>(CreateStudentHandlerName);
                var createTeacherHandler = context.Kernel.Get<IHandler>(CreateTeacherHandlerName);
                var removeStudentHandler = context.Kernel.Get<IHandler>(RemoveStudentHandlerName);
                var removeTeacherHandler = context.Kernel.Get<IHandler>(RemoveTeacherHandlerName);
                var studentListAllMarksHandler = context.Kernel.Get<IHandler>(StudentListAllMarksHandlerName);
                var teacherAddMarkHandler = context.Kernel.Get<IHandler>(TeacherAddMarkHandlerName);

                createStudentHandler.SetSuccessor(createTeacherHandler);
                createTeacherHandler.SetSuccessor(removeStudentHandler);
                removeStudentHandler.SetSuccessor(removeTeacherHandler);
                removeTeacherHandler.SetSuccessor(studentListAllMarksHandler);
                studentListAllMarksHandler.SetSuccessor(teacherAddMarkHandler);

                return createStudentHandler;
            }).WhenInjectedInto<CommandParserProvider>();
        }
    }
}