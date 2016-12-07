using System.Text;
using Dealership.Common.Enums;
using Dealership.DataStorage;

namespace Dealership.Engine.Handlers
{
    public class ShowUsersHandler : Handler
    {
        private const string YouAreNotAnAdmin = "You are not an admin!";

        protected override bool CanHandle(string commandName)
        {
            return commandName == "ShowUsers";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            if (data.LoggedUser.Role != Role.Admin)
            {
                return YouAreNotAnAdmin;
            }

            var builder = new StringBuilder();
            builder.AppendLine("--USERS--");
            var counter = 1;
            foreach (var user in data.Users)
            {
                builder.AppendLine(string.Format("{0}. {1}", counter, user.ToString()));
                counter++;
            }

            return builder.ToString().Trim();
        }
    }
}
