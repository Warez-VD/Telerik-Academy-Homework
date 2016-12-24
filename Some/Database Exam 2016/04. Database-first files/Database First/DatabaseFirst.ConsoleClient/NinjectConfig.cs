using Ninject;
using Ninject.Modules;
using System.Data.Entity;
using DatabaseFirst.Common;
using DatabaseFirst.Importer;
using DatabaseFirst.Data;
using DatabaseFirst.Importer.Importers;
using System.Collections.Generic;

namespace DatabaseFirst.ConsoleClient
{
    public class NinjectConfig : NinjectModule
    {
        private const string ComputerGpuImporterName = "ComputerGpuImporter";
        private const string ComputerImporterName = "ComputerImporter";
        private const string ComputerStorageDeviceImporterName = "ComputerStorageDeviceImporter";
        private const string CpuImporterName = "CpuImporter";
        private const string GpuImporterName = "GpuImporter";
        private const string StorageDeviceImporterName = "StorageDeviceImporter";

        public override void Load()
        {
            this.Bind<DbContext>().To<ComputersEntities>().InSingletonScope();
            this.Bind<IRepository<Computer>>().To<DatabaseFirstRepository<Computer>>();
            this.Bind<IRepository<Cpu>>().To<DatabaseFirstRepository<Cpu>>();
            this.Bind<IRepository<Gpu>>().To<DatabaseFirstRepository<Gpu>>();
            this.Bind<IRepository<StorageDevice>>().To<DatabaseFirstRepository<StorageDevice>>();
            this.Bind<IUnitOfWork>().To<UnitOfWork>();
            this.Bind<IRandom>().To<RandomGenerator>().InSingletonScope();
            this.Bind<IWriter>().To<ConsoleWriter>();

            this.Bind<IImporter>().To<CpuImporter>().Named(CpuImporterName);
            this.Bind<IImporter>().To<GpuImporter>().Named(GpuImporterName);
            this.Bind<IImporter>().To<StorageDeviceImporter>().Named(StorageDeviceImporterName);
            this.Bind<IImporter>().To<ComputerImporter>().Named(ComputerImporterName);
            this.Bind<IImporter>().To<ComputerGpuImporter>().Named(ComputerGpuImporterName);
            this.Bind<IImporter>().To<ComputerStorageDeviceImporter>().Named(ComputerStorageDeviceImporterName);
            
            this.Bind<IEnumerable<IImporter>>().ToMethod(context =>
            {
                IEnumerable<IImporter> allImporters = new List<IImporter>()
                {
                    context.Kernel.Get<IImporter>(CpuImporterName),
                    context.Kernel.Get<IImporter>(GpuImporterName),
                    context.Kernel.Get<IImporter>(StorageDeviceImporterName),
                    context.Kernel.Get<IImporter>(ComputerImporterName),
                    context.Kernel.Get<IImporter>(ComputerGpuImporterName),
                    context.Kernel.Get<IImporter>(ComputerStorageDeviceImporterName)
                };

                return allImporters;
            }).WhenInjectedInto<TheGreatImporter>();

            this.Bind<IGreatImporter>().To<TheGreatImporter>();
        }
    }
}
