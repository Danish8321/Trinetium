using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinetium.Contracts;
using Trinetium.Entities;
using Trinetium.Entities.Models;

namespace Trinetium.Repository
{
    public class ProductRepository : RepositoryBase<Products>, IProductRepository
    {
        private readonly NorthwindContext _northwindContext;

        public ProductRepository(NorthwindContext northwindContext) : base(northwindContext)
        {
            _northwindContext = northwindContext;
        }

        public async Task<List<Products>> FindAllActiveProducts()
        {
            var data = await _northwindContext.Products.Include(p => p.Category).AsNoTracking().ToListAsync();
            return data;
        }

    }
}
