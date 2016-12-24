using DatabaseFirst.Common;
using DatabaseFirst.Data;

namespace DatabaseFirst.Importer.Importers
{
    public class StorageDeviceImporter : IImporter
    {
        private const int StorageDevicesToAdd = 30;
        private const int StorageDevicesWithSSD = 8;
        private IRepository<StorageDevice> storageDevices;
        private IUnitOfWork unitOfWork;
        private IRandom random;

        public StorageDeviceImporter(IRepository<StorageDevice> storageDevices, IUnitOfWork unitOfWork, IRandom randomGenerator)
        {
            this.storageDevices = storageDevices;
            this.unitOfWork = unitOfWork;
            this.random = randomGenerator;
        }

        public void Import()
        {
            for (int i = 0; i < StorageDevicesToAdd; i++)
            {
                if (i < StorageDevicesWithSSD)
                {
                    var newStorageDeviceWithSSD = new StorageDevice()
                    {
                        Vendor = this.random.RandomString(5, 50),
                        Model = this.random.RandomString(5, 50),
                        Type = StorageDeviceType.SSD.ToString(),
                        Size = this.random.RandomNumber(100, 1000) + " GB"
                    };

                    this.storageDevices.Add(newStorageDeviceWithSSD);
                }

                var newStorageDeviceWithHDD = new StorageDevice()
                {
                    Vendor = this.random.RandomString(5, 50),
                    Model = this.random.RandomString(5, 50),
                    Type = StorageDeviceType.HDD.ToString(),
                    Size = this.random.RandomNumber(100, 1000) + " GB"
                };

                this.storageDevices.Add(newStorageDeviceWithHDD);
            }

            this.unitOfWork.Commit();
        }
    }
}
