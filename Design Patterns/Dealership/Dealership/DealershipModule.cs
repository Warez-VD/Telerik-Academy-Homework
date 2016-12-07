using Ninject.Modules;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using System.Reflection;
using System.IO;
using Dealership.Factories;
using Dealership.Contracts;
using Dealership.Engine;
using Dealership.Models;
using Dealership.Engine.Handlers;

namespace Dealership
{
    public class DealershipModule : NinjectModule
    {
        private const string CarName = "Car";
        private const string MotorcycleName = "Motorcycle";
        private const string TruckName = "Truck";

        private const string RegisterHandlerName = "RegisterHandler";
        private const string LoginHandlerName = "LoginHandler";
        private const string LogoutHandlerName = "LogoutHandler";
        private const string AddVehicleHandlerName = "AddVehicleHandler";
        private const string RemoveVehicleHandlerName = "RemoveVehicleHandler";
        private const string AddCommentHandlerName = "AddCommentHandler";
        private const string RemoveCommentHandlerName = "RemoveCommentHandler";
        private const string ShowUsersHandlerName = "ShowUsersHandler";
        private const string ShowVehiclesHandlerName = "ShowVehiclesHandler";

        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .SelectAllClasses()
                .BindDefaultInterface();
            });
            
            this.Bind<IEngine>().To<DealershipEngine>().InSingletonScope();

            this.Bind<IVehicle>().To<Car>().Named(CarName);
            this.Bind<IVehicle>().To<Motorcycle>().Named(MotorcycleName);
            this.Bind<IVehicle>().To<Truck>().Named(TruckName);
            
            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IWriter>().To<ConsoleWriter>();

            this.Bind<IUserFactory>().ToFactory().InSingletonScope();
            this.Bind<IVehicleFactory>().ToFactory().InSingletonScope();
            this.Bind<ICommentFactory>().ToFactory().InSingletonScope();

            this.Bind<IHandler>().To<RegisterHandler>().Named(RegisterHandlerName);
            this.Bind<IHandler>().To<LoginHandler>().Named(LoginHandlerName);
            this.Bind<IHandler>().To<LogoutHandler>().Named(LogoutHandlerName);
            this.Bind<IHandler>().To<AddVehicleHandler>().Named(AddVehicleHandlerName);
            this.Bind<IHandler>().To<RemoveVehicleHandler>().Named(RemoveVehicleHandlerName);
            this.Bind<IHandler>().To<AddCommentHandler>().Named(AddCommentHandlerName);
            this.Bind<IHandler>().To<RemoveCommentHandler>().Named(RemoveCommentHandlerName);
            this.Bind<IHandler>().To<ShowUsersHandler>().Named(ShowUsersHandlerName);
            this.Bind<IHandler>().To<ShowVehiclesHandler>().Named(ShowVehiclesHandlerName);
            this.Bind<IHandler>().ToMethod(context =>
            {
                var registerHandler = context.Kernel.Get<IHandler>(RegisterHandlerName);
                var logoutHandler = context.Kernel.Get<IHandler>(LogoutHandlerName);
                var loginHandler = context.Kernel.Get<IHandler>(LoginHandlerName);
                var addVehicleHandler = context.Kernel.Get<IHandler>(AddVehicleHandlerName);
                var removeVehicleHandler = context.Kernel.Get<IHandler>(RemoveVehicleHandlerName);
                var addCommentHandler = context.Kernel.Get<IHandler>(AddCommentHandlerName);
                var removeCommentHandler = context.Kernel.Get<IHandler>(RemoveCommentHandlerName);
                var showUserHandler = context.Kernel.Get<IHandler>(ShowUsersHandlerName);
                var showVehiclesHandler = context.Kernel.Get<IHandler>(ShowVehiclesHandlerName);

                registerHandler.SetSuccessor(logoutHandler);
                logoutHandler.SetSuccessor(loginHandler);
                loginHandler.SetSuccessor(addVehicleHandler);
                addVehicleHandler.SetSuccessor(removeVehicleHandler);
                removeVehicleHandler.SetSuccessor(addCommentHandler);
                addCommentHandler.SetSuccessor(removeCommentHandler);
                removeCommentHandler.SetSuccessor(showUserHandler);
                showUserHandler.SetSuccessor(showVehiclesHandler);

                return registerHandler;
            }).WhenInjectedInto<ICommandExecutor>();
        }
    }
}
