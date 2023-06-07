using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Services;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComputerController : ControllerBase
    {
        private readonly IComputerService _computerService;
        
        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }

        [HttpGet]
        public IActionResult GetAllComputers()
        {
            List<ComputerWithDescriptionsDto> computers = _computerService.GetAllComputersWithDescriptions();
            return new OkObjectResult(computers);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetComputer(int id)
        {
            ComputerWithPartsViewModel viewModel = _computerService.GetComputerViewModel(id);
            return new OkObjectResult(viewModel);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateComputer([FromRoute] int id, [FromBody] ComputerDto computer)
        {
            _computerService.UpdateComputer(computer);
            return new OkResult();
        }
        
        [HttpPost("{id}")]
        public IActionResult AddComputer([FromRoute] int id, [FromBody] ComputerDto computer)
        {
            _computerService.AddComputer(computer);
            return new OkResult();
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteComputer([FromRoute] int id)
        {
            _computerService.DeleteComputer(id);
            return new OkResult();
        }
    }
}