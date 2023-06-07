using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Models;

namespace Services
{
    public interface IProcessorService
    {
        Task<KeyValuePair<int, string>[]> GetProcessorKeyValues();
    }
    
    public class ProcessorService : IProcessorService
    {

        private readonly IUnitOfWork _unitOfWork;
        
        public ProcessorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<KeyValuePair<int, string>[]> GetProcessorKeyValues()
        {
            List<Processor> processors = await _unitOfWork.Processors.GetAllAsync();
            KeyValuePair<int,string>[] processorKeyValues = processors.Select(x => new KeyValuePair<int, string>(x.Id, $"{x.Name}"))
                .ToArray();

            return processorKeyValues;
        }
    }
}