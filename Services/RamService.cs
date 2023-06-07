using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Models;

namespace Services
{
    public interface IRamService
    {
        Task<KeyValuePair<int, string>[]> GetRamKeyValues();
    }
    
    public class RamService : IRamService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public RamService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<KeyValuePair<int, string>[]> GetRamKeyValues()
        {
            List<Ram> rams = await _unitOfWork.Rams.GetAllAsync();
            KeyValuePair<int,string>[] ramKeyValues = rams.Select(x => new KeyValuePair<int, string>(x.Id, $"{x.Size} {x.Unit}"))
                .ToArray();

            return ramKeyValues;
        }
    }
}