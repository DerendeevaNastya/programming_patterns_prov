using Xrm.ReportUtility.Interfaces;
using Xrm.ReportUtility.Models;

namespace Xrm.ReportUtility.Infrastructure.Transformers.Abstract
{
    //наследники абстрактного класса ReportServiceTransformerBase - обработчики, формируют цепочку (Chain Of Responsibility)
    public abstract class ReportServiceTransformerBase : IDataTransformer
    {
        protected readonly IDataTransformer DataTransformer;

        protected ReportServiceTransformerBase(IDataTransformer dataTransformer)
        {
            DataTransformer = dataTransformer;
        }

        // через этот метод аггрегируют dataRow 
        public abstract Report TransformData(DataRow[] data);
    }
}
