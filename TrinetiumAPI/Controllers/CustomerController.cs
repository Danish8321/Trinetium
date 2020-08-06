using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trinetium.Contracts;

namespace TrinetiumAPI.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        private readonly ILoggerManager _logger;

        public CustomerController(ILoggerManager logger, IRepositoryWrapper repo)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Customer()
        {
            return Ok(_repo.Customer.FindAll().ToList());
        }
    }
}
