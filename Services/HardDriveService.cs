using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Models;

namespace Services
{
    public interface IHardDriveService
    {
        Task<KeyValuePair<int, string>[]> GetHardDriveKeyValues();
    }
    
    public class HardDriveService : IHardDriveService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public HardDriveService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<KeyValuePair<int, string>[]> GetHardDriveKeyValues()
        {
            List<HardDrive> hardDrives = await _unitOfWork.HardDrives.GetAllAsync();
            KeyValuePair<int,string>[] hardDriveKeyValues = hardDrives.Select(x => new KeyValuePair<int, string>(x.Id, $"{x.Size}{x.StorageUnit} {x.HardDriveType}"))
                .ToArray();

            return hardDriveKeyValues;
        }
    }
}