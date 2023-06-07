using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public interface IUsbQuantityRepository : IGenericRepository<UsbQuantity>
    {
        List<UsbQuantity> GetForComputer(int id);
    }
    
    public class UsbQuantityRepository : GenericRepository<UsbQuantity>, IUsbQuantityRepository
    {
        public UsbQuantityRepository(OrionDbContext context) : base(context)
        {
            
        }

        public List<UsbQuantity> GetForComputer(int id)
        {
            return Context.UsbQuantity.Where(x => x.ComputerId == id).ToList();
        }
    }
}