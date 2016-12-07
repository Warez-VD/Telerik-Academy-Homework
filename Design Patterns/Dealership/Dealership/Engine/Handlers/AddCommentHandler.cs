using System.Linq;
using Dealership.Factories;
using Dealership.DataStorage;

namespace Dealership.Engine.Handlers
{
    public class AddCommentHandler : Handler
    {
        private const string VehicleDoesNotExist = "The vehicle does not exist!";
        private const string NoSuchUser = "There is no user with username {0}!";
        private const string CommentAddedSuccessfully = "{0} added comment successfully!";

        private ICommentFactory factory;

        public AddCommentHandler(ICommentFactory factory)
        {
            this.factory = factory;
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "AddComment";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            var content = command.Parameters[0];
            var author = command.Parameters[1];
            var vehicleIndex = int.Parse(command.Parameters[2]) - 1;

            return this.AddComment(content, vehicleIndex, author, data);
        }

        private string AddComment(string content, int vehicleIndex, string author, IStorage data)
        {
            var comment = this.factory.CreateComment(content);
            comment.Author = data.LoggedUser.Username;
            var user = data.Users.FirstOrDefault(u => u.Username == author);

            if (user == null)
            {
                return string.Format(NoSuchUser, author);
            }

            base.ValidateRange(vehicleIndex, 0, user.Vehicles.Count, VehicleDoesNotExist);

            var vehicle = user.Vehicles[vehicleIndex];

            data.LoggedUser.AddComment(comment, vehicle);

            return string.Format(CommentAddedSuccessfully, data.LoggedUser.Username);
        }
    }
}
