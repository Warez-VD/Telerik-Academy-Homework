using Ninject;
using SchoolSystem.Framework.Core;

namespace SchoolSystem.Cli
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel(new SchoolSystemModule());
            var engine = kernel.Get<IEngine>();
            engine.Start();
        }
    }
}