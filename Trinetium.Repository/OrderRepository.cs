using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinetium.Contracts;
using Trinetium.Entities;
using Trinetium.Entities.DTO;
using Trinetium.Entities.Models;

namespace Trinetium.Repository
{
    public class OrderRepository : RepositoryBase<Orders>, IOrderRepository
    {
        private readonly NorthwindContext _northwindContext;

        public OrderRepository(NorthwindContext northwindContext) : base(northwindContext)
        {
            _northwindContext = northwindContext;
        }

        public async Task<List<OrderListCustDto>> FindAllCustomerOrders(string Id)
        {
            // var data = _northwindContext.Orders.Include(p=>p.OrderDetails).Include(p=>p.OrderDetails.).Where(v => v.CustomerId == Id).in;
            var data = await (from tb1 in _northwindContext.Orders
                              join tb2 in _northwindContext.OrderDetails on tb1.OrderId equals tb2.OrderId
                              join tb3 in _northwindContext.Products on tb2.ProductId equals tb3.ProductId
                              join tb4 in _northwindContext.Categories on tb3.CategoryId equals tb4.CategoryId
                              where tb1.CustomerId == Id
                              select new OrderListCustDto
                              {
                                  OrderId = tb1.OrderId,
                                  OrderDate = tb1.OrderDate,
                                  RequiredDate = tb1.RequiredDate,
                                  ProductName = tb3.ProductName,
                                  Description = tb4.Description,
                                  Quantity = tb2.Quantity,
                                  UnitPrice = tb2.UnitPrice,
                                  Picture = tb4.Picture,
                              }).ToListAsync();
            return data;
        }
    }
}
