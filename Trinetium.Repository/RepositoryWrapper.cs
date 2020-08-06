using System;
using System.Collections.Generic;
using System.Text;
using Trinetium.Contracts;
using Trinetium.Entities;

namespace Trinetium.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private NorthwindContext _repoContext;
        private ICustomerRepository _customer;
        private IEmployeeRepository _employee;
        private IOrderRepository _order;
        private IProductRepository _product;
        private IAuthRepository _auth;

        public RepositoryWrapper(NorthwindContext northwindContext)
        {
            _repoContext = northwindContext;
        }
        public ICustomerRepository Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CustomerRepository(_repoContext);
                }
                return _customer;
            }
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new EmployeeRepository(_repoContext);
                }
                return _employee;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }
                return _product;
            }
        }

        public IOrderRepository Order
        {
            get
            {
                if (_order == null)
                {
                    _order = new OrderRepository(_repoContext);
                }
                return _order;
            }
        }

        public IAuthRepository Auth
        {
            get
            {
                if (_auth == null)
                {
                    _auth = new AuthRepository(_repoContext);
                }
                return _auth;
            }
        }



        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
