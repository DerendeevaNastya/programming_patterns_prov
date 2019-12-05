using System;
using Xrm.ReportUtility.Infrastructure.Handlers;
using Xrm.ReportUtility.Interfaces;

namespace Xrm.ReportUtility.Infrastructure
{
    public class ReportServiceCreator
    {
        private readonly string[] _args;
        private readonly ReportServiceHandler _handler;
        
        public ReportServiceCreator(string[] args)
        {
            _args = args;
            _handler = new TxtReportServiceHandler(null);
            _handler = new CsvReportServiceHandler(_handler);
            _handler = new XlsxReportServiceHandler(_handler);
        }

        public IReportService GetReportService()
        {
            IReportService reportService;
            if (_handler.TryGetReportService(_args[0], _args, out reportService))
            {
                return reportService;
            }
            
            throw new NotSupportedException("this extension not supported");
        }
    }
}