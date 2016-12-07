using System.Collections.Generic;
using System.Text;

namespace Dealership.Engine
{
    public class ReportPrinter : IReportPrinter
    {
        private IWriter writer;

        public ReportPrinter(IWriter writer)
        {
            this.writer = writer;
        }

        public void PrintReports(IEnumerable<string> reports)
        {
            var output = new StringBuilder();

            foreach (var report in reports)
            {
                output.AppendLine(report);
                output.AppendLine(new string('#', 20));
            }

            this.writer.Write(output.ToString());
        }
    }
}
