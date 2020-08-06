using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trinetium.Contracts;
using Trinetium.Entities.DTO;

namespace TrinetiumAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public ProductController(ILoggerManager logger, IRepositoryWrapper repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Product()
        {
            var products = _repo.Product.FindAll();
            var productsList = _mapper.Map<IEnumerable<ProductListCustDto>>(products);
            return Ok(productsList);
        }
    }
}
