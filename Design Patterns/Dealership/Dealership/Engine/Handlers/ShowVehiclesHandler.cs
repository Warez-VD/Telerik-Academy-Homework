using Dealership.DataStorage;
using System.Linq;

namespace Dealership.Engine.Handlers
{
    public class ShowVehiclesHandler : Handler
    {
        private const string NoSuchUser = "There is no user with username {0}!";

        protected override bool CanHandle(string commandName)
        {
            return commandName == "ShowVehicles";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            var username = command.Parameters[0];

            return this.ShowUserVehicles(username, data);
        }

        private string ShowUserVehicles(string username, IStorage data)
        {
            var user = data.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
            {
                return string.Format(NoSuchUser, username);
            }

            return user.PrintVehicles();
        }
    }
}
