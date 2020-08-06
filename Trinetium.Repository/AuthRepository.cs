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
    public class AuthRepository : RepositoryBase<Customers>, IAuthRepository
    {
        public AuthRepository(NorthwindContext northwindContext) : base(northwindContext)
        {

        }
        public async Task<Customers> Login(string username, string password)
        {
            var data = await FindByCondition(v => v.CustomerId == username && v.Phone == password).FirstOrDefaultAsync();
            return data;
        }

        public async Task<Customers> Register(Customers user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UserExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}
