using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface IUserService
    {
        Task<User> GetUserId(int id);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);      
        Task<bool> Delete(int id);
        Task<IEnumerable<User>> GetAll();
        Task<int> CountAll();  
    }
}
