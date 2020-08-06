using System;
using System.Collections.Generic;
using System.Text;
using Trinetium.Contracts;
using Trinetium.Entities;
using Trinetium.Entities.Models;

namespace Trinetium.Repository
{
    public class EmployeeRepository : RepositoryBase<Employees>, IEmployeeRepository
    {
        public EmployeeRepository(NorthwindContext northwindContext) : base(northwindContext)
        {
        }
    }
}
