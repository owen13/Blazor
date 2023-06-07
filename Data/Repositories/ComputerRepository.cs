using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public interface IComputerRepository : IGenericRepository<Computer>
    {
        Computer GetWithAllIncludes(int id);
        List<Computer> GetWithAllIncludes();
        Task<List<Computer>> GetWithAllIncludesAsync();
        Computer GetWithUsbs(int computerId);
        List<Computer> GetWithUsbs();
    }
    
    public class ComputerRepository : GenericRepository<Computer>, IComputerRepository
    {
        public ComputerRepository(OrionDbContext context) : base(context)
        {

        }

        private IQueryable<Computer> GetWithAllIncludesAsQueryable()
        {
            return Context.Computer
                .Include(x => x.Ram)
                .Include(x => x.GraphicsCard)
                .Include(x => x.HardDrive)
                .Include(x => x.Usbs)
                .Include(x => x.Processor)
                .AsQueryable();
        }
        
        public Computer GetWithAllIncludes(int id)
        {
            return GetWithAllIncludesAsQueryable().Single(x => x.Id == id);
        }
        public List<Computer> GetWithAllIncludes()
        {
            return GetWithAllIncludesAsQueryable().ToList();
        }

        public Task<List<Computer>> GetWithAllIncludesAsync()
        {
            return GetWithAllIncludesAsQueryable().ToListAsync();
        }

        private IQueryable<Computer> GetWithUsbsQueryable()
        {
            return Context.Computer
                .Include(x => x.Usbs);
        }

        public Computer GetWithUsbs(int computerId)
        {
            return GetWithUsbsQueryable()
                .Single(x => x.Id == computerId);
        }

        public List<Computer> GetWithUsbs()
        {
            return GetWithUsbsQueryable()
                .ToList();
        }
    }
}