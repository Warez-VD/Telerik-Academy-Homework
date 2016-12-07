using Ninject;
using Dealership.Engine;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel(new DealershipModule());

            var engine = kernel.Get<IEngine>();
            engine.Start();
        }
    }
}
