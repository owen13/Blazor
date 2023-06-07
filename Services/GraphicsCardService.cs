using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Models;

namespace Services
{
    public interface IGraphicsCardService
    {
        Task<KeyValuePair<int, string>[]> GetGraphicsCardKeyValues();
    }
    
    public class GraphicsCardService : IGraphicsCardService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public GraphicsCardService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<KeyValuePair<int, string>[]> GetGraphicsCardKeyValues()
        {
            List<GraphicsCard> graphicsCards = await _unitOfWork.GraphicsCards.GetAllAsync();
            KeyValuePair<int,string>[] graphicsCardKeyValues = graphicsCards.Select(x => new KeyValuePair<int, string>(x.Id, x.Name))
                .ToArray();

            return graphicsCardKeyValues;
        }
    }
}