using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trinetium.Contracts;

namespace TrinetiumAPI.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryWrapper _repo;

        public EmployeeController(ILoggerManager logger, IRepositoryWrapper repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Employee()
        {
            return Ok(_repo.Employee.FindAll().ToList());
        }

    }
}
