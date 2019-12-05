using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Services;

namespace Xrm.ReportUtility.Infrastructure.Handlers
{
    public class TxtReportServiceHandler : ReportServiceHandler
    {
        public TxtReportServiceHandler(ReportServiceHandler nextHandler) : base(nextHandler)
        {
        }

        public override bool TryGetReportService(string filename, string[] args, out IReportService reportService)
        {
            if (filename.EndsWith(".txt"))
            {
                reportService = new TxtReportService(args);
                return true;
            }
            return base.TryGetReportService(filename, args, out reportService);
        }
    }
}