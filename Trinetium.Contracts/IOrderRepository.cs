using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinetium.Entities.DTO;
using Trinetium.Entities.Models;

namespace Trinetium.Contracts
{
    public interface IOrderRepository : IRepositoryBase<Orders>
    {
        Task<List<OrderListCustDto>> FindAllCustomerOrders(string Id);
    }
}
