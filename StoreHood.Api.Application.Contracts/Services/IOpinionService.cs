using StoreHood.Api.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoreHood.Api.Application.Contracts
{
    public interface IOpinionService
    {
        Task<Opinion> GetOpinionId(int id);
        Task<Opinion> AddOpinion(Opinion opinion);
        Task<Opinion> UpdateOpinion(Opinion opinion);
        Task<bool> Delete(int id);
        Task<IEnumerable<Opinion>> GetAll();
        Task<int> CountAll();
    }
}
