using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Services;

namespace Xrm.ReportUtility.Infrastructure.Handlers
{
    public class XlsxReportServiceHandler : ReportServiceHandler
    {
        public XlsxReportServiceHandler(ReportServiceHandler nextHandler) : base(nextHandler)
        {
        }

        public override bool TryGetReportService(string filename, string[] args, out IReportService reportService)
        {
            if (filename.EndsWith(".xlsx"))
            {
                reportService = new XlsxReportService(args);
                return true;
            }
            return base.TryGetReportService(filename, args, out reportService);
        }
    }
}