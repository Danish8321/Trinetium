using System;
using System.Collections.Generic;
using System.Text;

namespace Trinetium.Contracts
{
    public interface IRepositoryWrapper
    {
        ICustomerRepository Customer { get; }
        IEmployeeRepository Employee { get; }
        IProductRepository Product { get; }
        IOrderRepository Order { get; }
        IAuthRepository Auth { get; }
        void Save();
    }
}
