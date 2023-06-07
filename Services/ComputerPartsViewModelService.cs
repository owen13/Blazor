using System.Threading.Tasks;
using Data;
using Models;

namespace Services
{
    public interface IComputerPartsViewModelService
    {
        Task<ComputerPartsModel> GetComputerPartsViewModel();
    }
    
    public class ComputerPartsViewModelService : IComputerPartsViewModelService
    {
        private readonly IRamService _ramService;
        private readonly IGraphicsCardService _graphicsCardService;
        private readonly IHardDriveService _hardDriveService;
        private readonly IProcessorService _processorService;

        public ComputerPartsViewModelService(IRamService ramService, IGraphicsCardService graphicsCardService, IHardDriveService hardDriveService, IProcessorService processorService)
        {
            _ramService = ramService;
            _graphicsCardService = graphicsCardService;
            _hardDriveService = hardDriveService;
            _processorService = processorService;
        }
        
        public async Task<ComputerPartsModel> GetComputerPartsViewModel()
        {
            return new ComputerPartsModel()
            {
                Rams = await _ramService.GetRamKeyValues(),
                GraphicsCards = await _graphicsCardService.GetGraphicsCardKeyValues(),
                HardDrives = await _hardDriveService.GetHardDriveKeyValues(),
                Processors = await _processorService.GetProcessorKeyValues(),
            };
        }
    }
}