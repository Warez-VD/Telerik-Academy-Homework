using DatabaseFirst.Common;
using DatabaseFirst.Data;

namespace DatabaseFirst.Importer.Importers
{
    public class GpuImporter : IImporter
    {
        private const int GpusToAdd = 15;
        private IRepository<Gpu> gpus;
        private IUnitOfWork unitOfWork;
        private IRandom random;

        public GpuImporter(IRepository<Gpu> gpus, IUnitOfWork unitOfWork, IRandom randomGenerator)
        {
            this.gpus = gpus;
            this.unitOfWork = unitOfWork;
            this.random = randomGenerator;
        }

        public void Import()
        {
            for (int i = 0; i < GpusToAdd; i++)
            {
                if (i < GpusToAdd / 3)
                {
                    var newCpuInternal = new Gpu()
                    {
                        Vendor = this.random.RandomString(5, 50),
                        Model = this.random.RandomString(5, 50),
                        Type = GpuType.Internal.ToString(),
                        Memory = this.random.RandomNumber(2, 10) + " GB"
                    };

                    this.gpus.Add(newCpuInternal);
                }

                var newCpuExternal = new Gpu()
                {
                    Vendor = this.random.RandomString(5, 50),
                    Model = this.random.RandomString(5, 50),
                    Type = GpuType.External.ToString(),
                    Memory = this.random.RandomNumber(2, 10) + " GB"
                };

                this.gpus.Add(newCpuExternal);

            }

            this.unitOfWork.Commit();
        }
    }
}
