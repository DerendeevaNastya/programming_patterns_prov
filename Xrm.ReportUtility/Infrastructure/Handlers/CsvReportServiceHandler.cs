using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Services;

namespace Xrm.ReportUtility.Infrastructure.Handlers
{
    public class CsvReportServiceHandler : ReportServiceHandler
    {
        public CsvReportServiceHandler(ReportServiceHandler nextHandler) : base(nextHandler)
        {
        }

        public override bool TryGetReportService(string filename, string[] args, out IReportService reportService)
        {
            if (filename.EndsWith(".csv"))
            {
                reportService = new CsvReportService(args);
                return true;
            }
            return base.TryGetReportService(filename, args, out reportService);
        }
    }
}