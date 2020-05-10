using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface IProfessionalService
    {
        Task<Professional> GetProfessionalId(int id);
        Task<Professional> AddProfessional(Professional proffesional);
        Task<Professional> UpdateProfessional(Professional proffesional);
        Task<bool> Delete(int id);
        Task<IEnumerable<Professional>> GetAll();
        Task<int> CountAll();
    }
}
