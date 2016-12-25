using DatabaseFirst.Common;
using DatabaseFirst.Data;
using System.Linq;

namespace DatabaseFirst.Importer.Importers
{
    public class ComputerStorageDeviceImporter : IImporter
    {
        private IRepository<Computer> computers;
        private IRepository<StorageDevice> storageDevices;
        private IUnitOfWork unitOfWork;
        private IRandom random;

        public ComputerStorageDeviceImporter(IRepository<Computer> computers, IRepository<StorageDevice> storageDevices, IUnitOfWork unitOfWork, IRandom randomGenerator)
        {
            this.computers = computers;
            this.storageDevices = storageDevices;
            this.unitOfWork = unitOfWork;
            this.random = randomGenerator;
        }

        public void Import()
        {
            var computerIds = this.computers.All().Select(c => c.Id).ToList();
            var storageDeviceIds = this.storageDevices.All().Select(s => s.Id).ToList();

            foreach (var computer in this.computers.All())
            {
                var id = storageDeviceIds[this.random.RandomNumber(1, storageDeviceIds.Count - 1)];
                var storageDevice = this.storageDevices.GetById(id);
                computer.StorageDevices.Add(storageDevice);
            }

            foreach (var storageDevice in this.storageDevices.All())
            {
                var id = computerIds[this.random.RandomNumber(1, computerIds.Count - 1)];
                var computer = this.computers.GetById(id);
                storageDevice.Computers.Add(computer);
            }

            this.unitOfWork.Commit();
        }
    }
}
