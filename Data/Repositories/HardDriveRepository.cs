using Models;

namespace Data
{
    public interface IHardDriveRepository : IGenericRepository<HardDrive>
    {
        
    }
    
    public class HardDriveRepository : GenericRepository<HardDrive>, IHardDriveRepository
    {
        public HardDriveRepository(OrionDbContext context) : base(context)
        {
            
        }
    }
}