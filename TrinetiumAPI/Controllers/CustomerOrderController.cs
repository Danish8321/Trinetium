using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Trinetium.Contracts;
using Trinetium.Entities.DTO;

namespace TrinetiumAPI.Controllers
{
    [Route("api/{customerId}/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;
        private readonly IRepositoryWrapper _repo;

        public CustomerOrderController(IMapper mapper, ILoggerManager logger, IRepositoryWrapper repo)
        {
            _mapper = mapper;
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> CustomerOrder(string customerId)
        {
            var data = await _repo.Order.FindAllCustomerOrders(customerId);
           // var custOrderList = _mapper.Map<IEnumerable<OrderListCustDto>>(data);
            return Ok(data);
        }
    }
}
