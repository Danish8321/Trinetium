using System;
using System.Collections.Generic;
using System.Text;
using Trinetium.Contracts;
using Trinetium.Entities;
using Trinetium.Entities.Models;

namespace Trinetium.Repository
{
    public class CustomerRepository : RepositoryBase<Customers>, ICustomerRepository
    {
        public CustomerRepository(NorthwindContext northwindContext) : base(northwindContext)
        {
        }
    }
}
