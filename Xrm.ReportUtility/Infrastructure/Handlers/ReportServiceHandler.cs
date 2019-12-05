using System;
using Xrm.ReportUtility.Interfaces;

namespace Xrm.ReportUtility.Infrastructure.Handlers
{
    public abstract class ReportServiceHandler
    {
        private readonly ReportServiceHandler _nextHandler;

        public ReportServiceHandler(ReportServiceHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual bool TryGetReportService(string filename, string[] args, out IReportService reportService)
        {
            if (_nextHandler == null)
            {
                reportService = null;
                return false;
            }

            return _nextHandler.TryGetReportService(filename, args, out reportService);
        }
    }
}