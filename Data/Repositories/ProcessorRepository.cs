using Models;

namespace Data
{
    public interface IProcessorRepository : IGenericRepository<Processor>
    {
        
    }
    
    public class ProcessorRepository : GenericRepository<Processor>, IProcessorRepository
    {
        public ProcessorRepository(OrionDbContext context) : base(context)
        {
            
        }
    }
}