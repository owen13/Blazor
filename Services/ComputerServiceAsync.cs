using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Mapster;
using Models;

namespace Services
{
    public interface IComputerServiceAsync
    {
        Task<List<ComputerWithDescriptionsDto>> GetAllComputersWithDescriptionsAsync();
    }
    
    public class ComputerServiceAsync : ComputerService, IComputerServiceAsync
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IComputerPartsViewModelService _computerPartsViewModelService;
        private readonly IUsbUpdaterService _usbUpdaterService;

        public ComputerServiceAsync(IUnitOfWork unitOfWork, IComputerPartsViewModelService computerPartsViewModelService, IUsbUpdaterService usbUpdaterService)
            : base(unitOfWork, computerPartsViewModelService, usbUpdaterService)
        {
            _unitOfWork = unitOfWork;
            _computerPartsViewModelService = computerPartsViewModelService;
            _usbUpdaterService = usbUpdaterService;
        }
        
        public async Task<List<ComputerWithDescriptionsDto>> GetAllComputersWithDescriptionsAsync()
        {
            List<Computer> computers = await _unitOfWork.Computers.GetWithAllIncludesAsync();
            List<ComputerWithDescriptionsDto> dtos = computers
                .Select(x => x.Adapt<ComputerWithDescriptionsDto>())
                .ToList();

            return dtos;
        }
    }
}