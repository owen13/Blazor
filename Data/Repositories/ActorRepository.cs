using Models;

namespace Data
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        
    }
    
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(OrionDbContext context) : base(context)
        {
            
        }
    }
}