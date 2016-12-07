using System;
using System.Linq;
using Dealership.Common.Enums;
using Dealership.Factories;
using Dealership.DataStorage;

namespace Dealership.Engine.Handlers
{
    public class RegisterHandler : Handler
    {
        private const string UserAlreadyExist = "User {0} already exist. Choose a different username!";
        private const string UserLoggedInAlready = "User {0} is logged in! Please log out first!";
        private const string UserRegisterеd = "User {0} registered successfully!";
        
        private IUserFactory factory;

        public RegisterHandler(IUserFactory factory)
        {
            this.factory = factory;
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "RegisterUser";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            var username = command.Parameters[0];
            var firstName = command.Parameters[1];
            var lastName = command.Parameters[2];
            var password = command.Parameters[3];

            var role = Role.Normal;

            if (command.Parameters.Count > 4)
            {
                role = (Role)Enum.Parse(typeof(Role), command.Parameters[4]);
            }

            return this.RegisterUser(username, firstName, lastName, password, role, data);
        }

        private string RegisterUser(string username, string firstName, string lastName, string password, Role role, IStorage data)
        {
            if (data.LoggedUser != null)
            {
                return string.Format(UserLoggedInAlready, data.LoggedUser.Username);
            }

            if (data.Users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                return string.Format(UserAlreadyExist, username);
            }

            var user = this.factory.CreateUser(username, firstName, lastName, password, role);
            data.LoggedUser = user;
            data.Users.Add(user);

            return string.Format(UserRegisterеd, username);
        }
    }
}
