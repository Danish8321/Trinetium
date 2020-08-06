using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trinetium.Entities.DTO;
using Trinetium.Entities.Models;

namespace Trinetium.Contracts
{
    public interface IAuthRepository
    {
        Task<Customers> Register(Customers user);
        Task<Customers> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
