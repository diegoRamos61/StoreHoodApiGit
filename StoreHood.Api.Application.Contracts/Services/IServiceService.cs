using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface IServiceService
    {
        Task<Service> GetServiceId(int id);
        Task<Service> AddService(Service service);
        Task<Service> UpdateService(Service service);
        Task<bool> Delete(int id);
        Task<IEnumerable<Service>> GetAll();
        Task<int> CountAll();
    }
}
