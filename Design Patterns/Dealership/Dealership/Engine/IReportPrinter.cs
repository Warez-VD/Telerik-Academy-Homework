using System.Collections.Generic;

namespace Dealership.Engine
{
    public interface IReportPrinter
    {
        void PrintReports(IEnumerable<string> reports);
    }
}
