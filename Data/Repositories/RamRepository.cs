using Models;

namespace Data
{
    public interface IRamRepository : IGenericRepository<Ram>
    {
        
    }
    
    public class RamRepository : GenericRepository<Ram>, IRamRepository
    {
        public RamRepository(OrionDbContext context) : base(context)
        {
            
        }
    }
}