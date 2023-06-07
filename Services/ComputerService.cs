using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Models;
using Mapster;
using MapsterMapper;
using Models.Enums;

namespace Services
{
    public interface IComputerService
    {
        List<ComputerWithDescriptionsDto> GetAllComputersWithDescriptions();
        ComputerDto GetComputer(int id);
        ComputerWithPartsViewModel GetComputerViewModel(int computerId);
        ComputerListWithPartsViewModel GetComputerListViewModel();
        ComputerWithDescriptionsDto UpdateComputer(ComputerDto dto);
        void AddComputer(ComputerDto dto);
        void DeleteComputer(int computerId);
    }
    
    public class ComputerService : IComputerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IComputerPartsViewModelService _computerPartsViewModelService;
        private readonly IUsbUpdaterService _usbUpdaterService;

        public ComputerService(IUnitOfWork unitOfWork, IComputerPartsViewModelService computerPartsViewModelService, IUsbUpdaterService usbUpdaterService)
        {
            _unitOfWork = unitOfWork;
            _computerPartsViewModelService = computerPartsViewModelService;
            _usbUpdaterService = usbUpdaterService;
        }

        public List<ComputerWithDescriptionsDto> GetAllComputersWithDescriptions()
        {
            List<Computer> computers = _unitOfWork.Computers.GetWithAllIncludes();
            List<ComputerWithDescriptionsDto> dtos = computers
                .Select(x => x.Adapt<ComputerWithDescriptionsDto>())
                .ToList();

            return dtos;
        }

        public ComputerWithDescriptionsDto GetComputerWithDescription(int computerId)
        {
            Computer computer = _unitOfWork.Computers.GetWithAllIncludes(computerId);
            ComputerWithDescriptionsDto dto = computer.Adapt<ComputerWithDescriptionsDto>();
            return dto;
        }

        public ComputerDto GetComputer(int id)
        {
            Computer computer = _unitOfWork.Computers.GetWithUsbs(id);
            ComputerDto computerDto = computer.Adapt<ComputerDto>();
            return computerDto;
        }

        public ComputerWithPartsViewModel GetComputerViewModel(int computerId)
        {
            ComputerWithPartsViewModel model = new ComputerWithPartsViewModel()
            {
                PartLists = _computerPartsViewModelService.GetComputerPartsViewModel().Result
            };
            
            if (computerId == 0) // Add Mode
                model.Computer = new ComputerDto(); 
            else // Edit Mode
                model.Computer = _unitOfWork.Computers.GetWithUsbs(computerId).Adapt<ComputerDto>();

            return model;
        }

        public ComputerListWithPartsViewModel GetComputerListViewModel()
        {
            List<Computer> computers = _unitOfWork.Computers.GetWithAllIncludes();
            ComputerWithDescriptionsDto[] dtos = computers.Select(x => x.Adapt<ComputerWithDescriptionsDto>()).ToArray();
            
            ComputerListWithPartsViewModel viewModel = new ComputerListWithPartsViewModel()
            {
                Computers = dtos,
                PartLists = _computerPartsViewModelService.GetComputerPartsViewModel().Result
            };

            return viewModel;
        }

        public ComputerWithDescriptionsDto UpdateComputer(ComputerDto dto)
        {
            Computer computer = _unitOfWork.Computers.GetWithUsbs(dto.Id);

            dto.Adapt(computer);
            _usbUpdaterService.AddOrUpdateUpdateComputerUsbs(computer, dto);

            _unitOfWork.SubmitChanges();

            ComputerWithDescriptionsDto result = GetComputerWithDescription(dto.Id);
            
            return result;
        }

        public void AddComputer(ComputerDto dto)
        {
            Computer newComputer = dto.Adapt<Computer>();
            _usbUpdaterService.AddOrUpdateUpdateComputerUsbs(newComputer, dto);
            
            _unitOfWork.Computers.Add(newComputer);
            _unitOfWork.SubmitChanges();
        }

        public void DeleteComputer(int computerId)
        {
            Computer computer = _unitOfWork.Computers.GetById(computerId);
            _unitOfWork.Computers.Remove(computer);
            _unitOfWork.SubmitChanges();
        }
    }
}