using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinetium.Entities.Models;

namespace Trinetium.Contracts
{
    public interface IProductRepository : IRepositoryBase<Products>
    {
        Task<List<Products>> FindAllActiveProducts();
    }
}
