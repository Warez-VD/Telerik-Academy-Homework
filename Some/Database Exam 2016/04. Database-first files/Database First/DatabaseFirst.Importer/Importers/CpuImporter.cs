using DatabaseFirst.Common;
using DatabaseFirst.Data;

namespace DatabaseFirst.Importer.Importers
{
    public class CpuImporter : IImporter
    {
        private const int CpusToAdd = 10;
        private IRepository<Cpu> cpus;
        private IUnitOfWork unitOfWork;
        private IRandom random;

        public CpuImporter(IRepository<Cpu> cpus, IUnitOfWork unitOfWork, IRandom randomGenerator)
        {
            this.cpus = cpus;
            this.unitOfWork = unitOfWork;
            this.random = randomGenerator;
        }

        public void Import()
        {
            for (int i = 0; i < CpusToAdd; i++)
            {
                var newCpu = new Cpu()
                {
                    Vendor = this.random.RandomString(5, 50),
                    Model = this.random.RandomString(5, 50),
                    NumberOfCores = this.random.RandomNumber(1, 32),
                    ClockCycles = this.random.RandomNumber(1, 5) + " Ghz"
                };
                
                this.cpus.Add(newCpu);
            }

            this.unitOfWork.Commit();
        }
    }
}
