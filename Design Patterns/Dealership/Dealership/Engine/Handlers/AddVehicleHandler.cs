using System;
using Dealership.Contracts;
using Dealership.Common.Enums;
using Dealership.Factories;
using Dealership.DataStorage;

namespace Dealership.Engine.Handlers
{
    public class AddVehicleHandler : Handler
    {
        private const string VehicleAddedSuccessfully = "{0} added vehicle successfully!";

        private IVehicleFactory factory;

        public AddVehicleHandler(IVehicleFactory factory)
        {
            this.factory = factory;
        }

        protected override bool CanHandle(string commandName)
        {
            return commandName == "AddVehicle";
        }

        protected override string Handle(ICommand command, IStorage data)
        {
            var type = command.Parameters[0];
            var make = command.Parameters[1];
            var model = command.Parameters[2];
            var price = decimal.Parse(command.Parameters[3]);
            var additionalParam = command.Parameters[4];

            var typeEnum = (VehicleType)Enum.Parse(typeof(VehicleType), type, true);

            return this.AddVehicle(typeEnum, make, model, price, additionalParam, data);
        }

        private string AddVehicle(VehicleType type, string make, string model, decimal price, string additionalParam, IStorage data)
        {
            IVehicle vehicle = null;

            if (type == VehicleType.Car)
            {
                vehicle = this.factory.GetCar(make, model, price, int.Parse(additionalParam));
            }
            else if (type == VehicleType.Motorcycle)
            {
                vehicle = this.factory.GetMotorcycle(make, model, price, additionalParam);
            }
            else if (type == VehicleType.Truck)
            {
                vehicle = this.factory.GetTruck(make, model, price, int.Parse(additionalParam));
            }

            data.LoggedUser.AddVehicle(vehicle);

            return string.Format(VehicleAddedSuccessfully, data.LoggedUser.Username);
        }
    }
}
