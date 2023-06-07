using Models;

namespace Data
{
    public interface IGraphicsCardRepository : IGenericRepository<GraphicsCard>
    {
        
    }
    
    public class GraphicsCardRepository : GenericRepository<GraphicsCard>, IGraphicsCardRepository
    {
        public GraphicsCardRepository(OrionDbContext context) : base(context)
        {
            
        }
    }
}