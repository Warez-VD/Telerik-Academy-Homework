using Dealership.DataStorage;
using System.Linq;

namespace Dealership.Engine.Handlers
{
    public class LoginHandler : Handler
    {
        private const string UserLoggedInAlready = "User {0} is logged in! Please log out first!";
        private const string UserLoggedIn = "User {0} successfully logged in!";
        private const string WrongUsernameOrPassword = "Wrong username or password!";

        protected override bool CanHandle(string commandName)
        {
            return commandName == "Login";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            var username = command.Parameters[0];
            var password = command.Parameters[1];

            return this.Login(username, password, data);
        }

        private string Login(string username, string password, IStorage data)
        {
            if (data.LoggedUser != null)
            {
                return string.Format(UserLoggedInAlready, data.LoggedUser.Username);
            }

            var userFound = data.Users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (userFound != null && userFound.Password == password)
            {
                data.LoggedUser = userFound;
                return string.Format(UserLoggedIn, username);
            }

            return WrongUsernameOrPassword;
        }
    }
}
