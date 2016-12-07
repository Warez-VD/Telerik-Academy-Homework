using Dealership.DataStorage;

namespace Dealership.Engine.Handlers
{
    public class LogoutHandler : Handler
    {
        private const string UserLoggedOut = "You logged out!";

        protected override bool CanHandle(string commandName)
        {
            return commandName == "Logout";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            data.LoggedUser = null;
            return UserLoggedOut;
        }
    }
}
