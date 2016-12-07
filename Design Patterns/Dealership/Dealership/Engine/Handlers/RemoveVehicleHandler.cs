using Dealership.DataStorage;

namespace Dealership.Engine.Handlers
{
    public class RemoveVehicleHandler : Handler
    {
        private const string RemovedVehicleDoesNotExist = "Cannot remove comment! The vehicle does not exist!";
        private const string VehicleRemovedSuccessfully = "{0} removed vehicle successfully!";

        protected override bool CanHandle(string commandName)
        {
            return commandName == "RemoveVehicle";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            var vehicleIndex = int.Parse(command.Parameters[0]) - 1;

            return this.RemoveVehicle(vehicleIndex, data);
        }

        private string RemoveVehicle(int vehicleIndex, IStorage data)
        {
            base.ValidateRange(vehicleIndex, 0, data.LoggedUser.Vehicles.Count, RemovedVehicleDoesNotExist);

            var vehicle = data.LoggedUser.Vehicles[vehicleIndex];

            data.LoggedUser.RemoveVehicle(vehicle);

            return string.Format(VehicleRemovedSuccessfully, data.LoggedUser.Username);
        }
    }
}
