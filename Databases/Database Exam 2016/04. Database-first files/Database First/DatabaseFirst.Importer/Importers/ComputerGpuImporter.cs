using DatabaseFirst.Common;
using DatabaseFirst.Data;
using System.Linq;

namespace DatabaseFirst.Importer.Importers
{
    public class ComputerGpuImporter : IImporter
    {
        private IRepository<Computer> computers;
        private IRepository<Gpu> gpus;
        private IUnitOfWork unitOfWork;
        private IRandom random;

        public ComputerGpuImporter(IRepository<Computer> computers, IRepository<Gpu> gpus, IUnitOfWork unitOfWork, IRandom randomGenerator)
        {
            this.computers = computers;
            this.gpus = gpus;
            this.unitOfWork = unitOfWork;
            this.random = randomGenerator;
        }

        public void Import()
        {
            var computerIds = this.computers.All().Select(c => c.Id).ToList();
            var gpuIds = this.gpus.All().Select(g => g.Id).ToList();

            foreach (var computer in this.computers.All())
            {
                var id = gpuIds[this.random.RandomNumber(1, gpuIds.Count - 1)];
                var gpu = this.gpus.GetById(id);
                computer.Gpus.Add(gpu);
            }

            foreach (var gpu in this.gpus.All())
            {
                var id = computerIds[this.random.RandomNumber(1, computerIds.Count - 1)];
                var computer = this.computers.GetById(id);
                gpu.Computers.Add(computer);
            }

            this.unitOfWork.Commit();
        }
    }
}
