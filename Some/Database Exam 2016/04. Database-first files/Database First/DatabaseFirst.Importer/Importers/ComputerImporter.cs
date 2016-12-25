using System.Linq;
using DatabaseFirst.Common;
using DatabaseFirst.Data;

namespace DatabaseFirst.Importer.Importers
{
    public class ComputerImporter : IImporter
    {
        private const int ComputersToAdd = 50;
        private const int OneThird = 15;
        private IRepository<Computer> computers;
        private IRepository<Cpu> cpus;
        private IUnitOfWork unitOfWork;
        private IRandom random;

        public ComputerImporter(IRepository<Computer> computers, IRepository<Cpu> cpus, IUnitOfWork unitOfWork, IRandom randomGenerator)
        {
            this.computers = computers;
            this.cpus = cpus;
            this.unitOfWork = unitOfWork;
            this.random = randomGenerator;
        }

        public void Import()
        {
            var cpuIds = this.cpus.All().Select(c => c.Id).ToList();

            for (int i = 0; i < ComputersToAdd; i++)
            {
                if (i < OneThird)
                {
                    var newComputerNotebook = new Computer()
                    {
                        Type = ComputerType.Notebook.ToString(),
                        Vendor = this.random.RandomString(5, 50),
                        Model = this.random.RandomString(5, 50),
                        CpuId = cpuIds[this.random.RandomNumber(0, cpuIds.Count - 1)],
                        Memory = this.random.RandomNumber(4, 64) + " GB"
                    };

                    this.computers.Add(newComputerNotebook);
                }
                else if (i > OneThird && i < OneThird * 2)
                {
                    var newComputerDesktop = new Computer()
                    {
                        Type = ComputerType.Desktop.ToString(),
                        Vendor = this.random.RandomString(5, 50),
                        Model = this.random.RandomString(5, 50),
                        CpuId = cpuIds[this.random.RandomNumber(0, cpuIds.Count - 1)],
                        Memory = this.random.RandomNumber(4, 64) + " GB"
                    };

                    this.computers.Add(newComputerDesktop);
                }
                else
                {
                    var newComputerUltrabook = new Computer()
                    {
                        Type = ComputerType.Ultrabook.ToString(),
                        Vendor = this.random.RandomString(5, 50),
                        Model = this.random.RandomString(5, 50),
                        CpuId = cpuIds[this.random.RandomNumber(0, cpuIds.Count - 1)],
                        Memory = this.random.RandomNumber(4, 64) + " GB"
                    };

                    this.computers.Add(newComputerUltrabook);
                }
            }

            this.unitOfWork.Commit();
        }
    }
}
