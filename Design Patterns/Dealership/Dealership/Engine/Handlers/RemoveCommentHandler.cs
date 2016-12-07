using Dealership.DataStorage;
using System.Linq;

namespace Dealership.Engine.Handlers
{
    public class RemoveCommentHandler : Handler
    {
        private const string CommentRemovedSuccessfully = "{0} removed comment successfully!";
        private const string RemovedVehicleDoesNotExist = "Cannot remove comment! The vehicle does not exist!";
        private const string RemovedCommentDoesNotExist = "Cannot remove comment! The comment does not exist!";
        private const string NoSuchUser = "There is no user with username {0}!";

        protected override bool CanHandle(string commandName)
        {
            return commandName == "RemoveComment";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            var vehicleIndex = int.Parse(command.Parameters[0]) - 1;
            var commentIndex = int.Parse(command.Parameters[1]) - 1;
            var username = command.Parameters[2];

            return this.RemoveComment(vehicleIndex, commentIndex, username, data);
        }

        private string RemoveComment(int vehicleIndex, int commentIndex, string username, IStorage data)
        {
            var user = data.Users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                return string.Format(NoSuchUser, username);
            }

            base.ValidateRange(vehicleIndex, 0, user.Vehicles.Count, RemovedVehicleDoesNotExist);
            base.ValidateRange(commentIndex, 0, user.Vehicles[vehicleIndex].Comments.Count, RemovedCommentDoesNotExist);

            var vehicle = user.Vehicles[vehicleIndex];
            var comment = user.Vehicles[vehicleIndex].Comments[commentIndex];

            data.LoggedUser.RemoveComment(comment, vehicle);

            return string.Format(CommentRemovedSuccessfully, data.LoggedUser.Username);
        }
    }
}
